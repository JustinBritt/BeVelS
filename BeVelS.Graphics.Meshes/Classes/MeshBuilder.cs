namespace BeVelS.Graphics.Meshes.Classes
{
    using System.Collections.Generic;
    using System.IO;

    using ObjLoader.Loader.Loaders;

    using BeVelS.Common.Meshes.Interfaces;
    using BeVelS.Common.Meshes.InterfacesFactories;
    using BeVelS.Common.Triangles.InterfacesFactories;
    using BeVelS.Common.Triangles.Structs;
    using BeVelS.Common.Vectors.InterfacesFactories;

    using BeVelS.Dependencies.AssimpNet.InterfacesFactories;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoContentBuilder/MeshBuilder.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges,
        "Removed ContentType property",
        "Added BuildAssimp method")]
    public static class MeshBuilder
    {
        class MaterialStubLoader : IMaterialStreamProvider
        {
            public Stream Open(
                string materialFilePath)
            {
                return null;
            }
        }

        public unsafe static IMeshContent BuildAssimp(
            IVector3Factory vector3Factory,
            IAssimpContextFactory AssimpContextFactory,
            IMeshContentFactory meshContentFactory,
            ITriangleContentFactory triangleContentFactory,
            string path)
        {
            Assimp.Scene aiScene;

            Assimp.AssimpContext aiContext = AssimpContextFactory.Create();

            aiScene = aiContext.ImportFile(
                path);

            List<TriangleContent> triangles = new List<TriangleContent>();

            foreach (Assimp.Mesh mesh in aiScene.Meshes)
            {
                foreach (Assimp.Face face in mesh.Faces)
                {
                    Assimp.Vector3D a = mesh.Vertices[face.Indices[0]];

                    for (int k = 1; k < face.Indices.Count - 1; k = k + 1)
                    {
                        Assimp.Vector3D b = mesh.Vertices[face.Indices[k]];

                        Assimp.Vector3D c = mesh.Vertices[face.Indices[k + 1]];

                        triangles.Add(
                            triangleContentFactory.Create(
                                A: vector3Factory.Create(a.X, a.Y, a.Z),
                                B: vector3Factory.Create(b.X, b.Y, b.Z),
                                C: vector3Factory.Create(c.X, c.Y, c.Z)));
                    }
                }
            }

            return meshContentFactory.Create(
                triangles.ToArray());
        }

        public unsafe static IMeshContent BuildObj(
            IVector3Factory vector3Factory,
            IMeshContentFactory meshContentFactory,
            Stream dataStream)
        {
            LoadResult result = new ObjLoaderFactory().Create(new MaterialStubLoader()).Load(dataStream);

            List<TriangleContent> triangles = new List<TriangleContent>();

            for (int i = 0; i < result.Groups.Count; ++i)
            {
                var group = result.Groups[i];

                for (int j = 0; j < group.Faces.Count; ++j)
                {
                    var face = group.Faces[j];

                    // 1, 5, 1, 2, 3, 5 -> 0, 4, 0, 1, 2, 4
                    var a = result.Vertices[face[0].VertexIndex - 1];

                    for (int k = 1; k < face.Count - 1; ++k)
                    {
                        // 4, 3, 6, 7, 2, 6, 3, 7, 4, 8, 8, 4 -> 3, 2, 5, 6, 1, 5, 2, 6, 3, 7, 7, 3
                        var b = result.Vertices[face[k].VertexIndex - 1];

                        // 3, 2, 7, 8, 6, 5, 7, 6, 8, 7, 4, 1 -> 2, 1, 6, 7, 5, 4, 6, 5, 7, 6, 3, 0
                        var c = result.Vertices[face[k + 1].VertexIndex - 1];

                        triangles.Add(
                            new TriangleContent
                            {
                                A = vector3Factory.Create(a.X, a.Y, a.Z),
                                B = vector3Factory.Create(b.X, b.Y, b.Z),
                                C = vector3Factory.Create(c.X, c.Y, c.Z)
                            });
                    }
                }
            }

            return meshContentFactory.Create(
                triangles.ToArray());
        }
    }
}