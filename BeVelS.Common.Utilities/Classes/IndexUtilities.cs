namespace BeVelS.Common.Utilities.Classes
{
    using System;

    using BeVelS.Licensing.Classes;

    [BepuPhysicsLicensedCode(
        boilerplate: BepuPhysicsLicensedCodeAttribute.ApacheLicenseVersion20Boilerplate,
        copyrightOwner: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightOwner,
        copyrightYears: BepuPhysicsLicensedCodeAttribute.BepuPhysicsCopyrightYears,
        source: "https://github.com/bepu/bepuphysics2/blob/master/DemoRenderer/Helpers.cs",
        BepuPhysicsLicensedCodeAttribute.FormattingChanges)]
    public static class IndexUtilities
    {
        private const int boxNumberIndices = 36;

        public static uint[] GetBoxIndices(
            int boxCount)
        {
            // Build a AABB mesh's index buffer, repeated. A redundant index buffer tends to be faster than instancing tiny models. Impact varies between hardware.
            uint[] indexData = (uint[])(Array.CreateInstance(
                typeof(uint),
                boxCount * boxNumberIndices));

            uint baseVertex = 0;

            for (int glyphIndexStart = 0; glyphIndexStart < indexData.Length; glyphIndexStart += 36)
            {
                // Note that the order and winding is important and must be consistent with the RenderSpheres.hlsl VS usage.
                // It assumes that an unset bit in the 3-bit string of the vertex id corresponds to the minimum position: 
                // vertex id 0 becomes (-1, -1, -1), while vertex id 7 becomes (1, 1, 1).

                // -X
                indexData[glyphIndexStart + 0] = baseVertex + 0;
                indexData[glyphIndexStart + 1] = baseVertex + 4;
                indexData[glyphIndexStart + 2] = baseVertex + 6;
                indexData[glyphIndexStart + 3] = baseVertex + 6;
                indexData[glyphIndexStart + 4] = baseVertex + 2;
                indexData[glyphIndexStart + 5] = baseVertex + 0;

                // +X
                indexData[glyphIndexStart + 6] = baseVertex + 5;
                indexData[glyphIndexStart + 7] = baseVertex + 1;
                indexData[glyphIndexStart + 8] = baseVertex + 3;
                indexData[glyphIndexStart + 9] = baseVertex + 3;
                indexData[glyphIndexStart + 10] = baseVertex + 7;
                indexData[glyphIndexStart + 11] = baseVertex + 5;
                
                // -Y
                indexData[glyphIndexStart + 12] = baseVertex + 0;
                indexData[glyphIndexStart + 13] = baseVertex + 1;
                indexData[glyphIndexStart + 14] = baseVertex + 5;
                indexData[glyphIndexStart + 15] = baseVertex + 5;
                indexData[glyphIndexStart + 16] = baseVertex + 4;
                indexData[glyphIndexStart + 17] = baseVertex + 0;
                
                // +Y
                indexData[glyphIndexStart + 18] = baseVertex + 2;
                indexData[glyphIndexStart + 19] = baseVertex + 6;
                indexData[glyphIndexStart + 20] = baseVertex + 7;
                indexData[glyphIndexStart + 21] = baseVertex + 7;
                indexData[glyphIndexStart + 22] = baseVertex + 3;
                indexData[glyphIndexStart + 23] = baseVertex + 2;
                
                // -Z
                indexData[glyphIndexStart + 24] = baseVertex + 1;
                indexData[glyphIndexStart + 25] = baseVertex + 0;
                indexData[glyphIndexStart + 26] = baseVertex + 2;
                indexData[glyphIndexStart + 27] = baseVertex + 2;
                indexData[glyphIndexStart + 28] = baseVertex + 3;
                indexData[glyphIndexStart + 29] = baseVertex + 1;
                
                // +Z
                indexData[glyphIndexStart + 30] = baseVertex + 4;
                indexData[glyphIndexStart + 31] = baseVertex + 5;
                indexData[glyphIndexStart + 32] = baseVertex + 7;
                indexData[glyphIndexStart + 33] = baseVertex + 7;
                indexData[glyphIndexStart + 34] = baseVertex + 6;
                indexData[glyphIndexStart + 35] = baseVertex + 4;
                
                baseVertex += 8;
            }

            return indexData;
        }

        public static uint[] GetQuadIndices(
            int quadCount)
        {
            uint[] indexData = new uint[quadCount * 6];

            uint baseVertex = 0;

            for (int glyphIndexStart = 0; glyphIndexStart < indexData.Length; glyphIndexStart += 6)
            {
                //Front facing triangles are counterclockwise.
                // Quad layout: 
                //  0____1
                //  |  / |
                //  | /  |
                //  2____3
                // 0 2 1
                // 1 2 3 

                indexData[glyphIndexStart + 0] = baseVertex + 0;
                indexData[glyphIndexStart + 1] = baseVertex + 2;
                indexData[glyphIndexStart + 2] = baseVertex + 1;
                indexData[glyphIndexStart + 3] = baseVertex + 1;
                indexData[glyphIndexStart + 4] = baseVertex + 2;
                indexData[glyphIndexStart + 5] = baseVertex + 3;

                baseVertex += 4;
            }

            return indexData;
        }
    }
}