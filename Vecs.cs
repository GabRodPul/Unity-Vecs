// #define GRPU_VECS_EXTENSION

using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


using UV2 = UnityEngine.Vector2;
using UV2I = UnityEngine.Vector2Int;
using UV3 = UnityEngine.Vector3;
using UV3I = UnityEngine.Vector3Int;
using UV4 = UnityEngine.Vector4;

using SNV2 = System.Numerics.Vector2;
using SNV3 = System.Numerics.Vector3;
using SNV4 = System.Numerics.Vector4;

namespace GRP.Unity
{
    public static class GRPU_Vecs
    {
#if GRPU_VECS_EXTENSION
#if false
        // Set[Axis]
        // X
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX(this ref V2 v, float newX) => v.x = newX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX(this ref V2I v, int newX)  => v.x = newX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX(this ref V3 v, float newX) => v.x = newX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX(this ref V3I v, int newX)  => v.x = newX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX(this ref V4 v, float newX) => v.x = newX;

        // Y
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY(this ref V2 v, float newY) => v.y = newY;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY(this ref V2I v, int newY)  => v.y = newY;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY(this ref V3 v, float newY) => v.y = newY;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY(this ref V3I v, int newY)  => v.y = newY;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY(this ref V4 v, float newY) => v.y = newY;

        // Z
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZ(this ref V3 v, float newZ) => v.z = newZ;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZ(this ref V3I v, int newZ)  => v.z = newZ;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZ(this ref V4 v, float newZ) => v.z = newZ;

        // W
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetW(this ref V4 v, float newW) => v.w = newW;
#endif // Set

        // With[Axis]
        // X
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2 WithX(this UV2 v, float newX) => new(newX, v.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2I WithX(this UV2I v, int newX) => new(newX, v.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithX(this UV3 v, float newX) => new(newX, v.y, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithX(this UV3I v, int newX) => new(newX, v.y, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithX(this UV4 v, float newX) => new(newX, v.y, v.z, v.w);

        // Y
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2 WithY(this UV2 v, float newY) => new(v.x, newY);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2I WithY(this UV2I v, int newY) => new(v.x, newY);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithY(this UV3 v, float newY) => new(v.x, newY, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithY(this UV3I v, int newY) => new(v.x, newY, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithY(this UV4 v, float newY) => new(v.x, newY, v.z, v.w);

        // Z
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithZ(this UV3 v, float newZ) => new(v.x, v.y, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithZ(this UV3I v, int newZ) => new(v.x, v.y, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithZ(this UV4 v, float newZ) => new(v.x, v.y, newZ, v.w);

        // W
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithW(this UV4 v, float newW) => new(v.x, v.y, v.z, newW);

        // With[Axes]
        // XY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithXY(this UV3 v, float newX, float newY) => new(newX, newY, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithXY(this UV3I v, int newX, int newY) => new(newX, newY, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXY(this UV4 v, float newX, float newY) => new(newX, newY, v.z, v.w);

        // XZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithXZ(this UV3 v, float newX, float newZ) => new(newX, v.y, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithXZ(this UV3I v, int newX, int newZ) => new(newX, v.y, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXZ(this UV4 v, float newX, float newZ) => new(newX, v.y, newZ, v.w);

        // YZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithYZ(this UV3 v, float newY, float newZ) => new(v.x, newY, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithYZ(this UV3I v, int newY, int newZ) => new(v.x, newY, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithYZ(this UV4 v, float newY, float newZ) => new(v.x, newY, newZ, v.w);

        // XW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXW(this UV4 v, float newX, float newW) => new(newX, v.y, v.z, newW);

        // YW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithYW(this UV4 v, float newY, float newW) => new(v.x, newY, v.z, newW);

        // ZW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithZW(this UV4 v, float newZ, float newW) => new(v.x, v.y, newZ, newW);

        // XYZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXYZ(this UV4 v, float newX, float newY, float newZ) => new(newX, newY, newZ, v.w);

        // XZW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXZW(this UV4 v, float newX, float newZ, float newW) => new(newX, v.y, newZ, newW);

        // YZW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithYZW(this UV4 v, float newY, float newZ, float newW) => new(v.x, newY, newZ, newW);


        // System.Numerics.Vector & UnityEngine.Vector
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SNV2 ToNumerics(this UV2 v) => new SNV2(v.x, v.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SNV3 ToNumerics(this UV3 v) => new SNV3(v.x, v.y, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SNV4 ToNumerics(this UV4 v) => new SNV4(v.x, v.y, v.z, v.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2 ToUnity(this SNV2 v) => new UV2(v.X, v.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 ToUnity(this SNV3 v) => new UV3(v.X, v.Y, v.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 ToUnity(this SNV4 v) => new UV4(v.X, v.Y, v.Z, v.W);
#else
#if false
        // Set[Axis]
        // X
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX( ref V2 v, float newX) => v.x = newX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX( ref V2I v, int newX)  => v.x = newX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX( ref V3 v, float newX) => v.x = newX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX( ref V3I v, int newX)  => v.x = newX;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetX( ref V4 v, float newX) => v.x = newX;

        // Y
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY( ref V2 v, float newY) => v.y = newY;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY( ref V2I v, int newY)  => v.y = newY;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY( ref V3 v, float newY) => v.y = newY;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY( ref V3I v, int newY)  => v.y = newY;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetY( ref V4 v, float newY) => v.y = newY;

        // Z
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZ( ref V3 v, float newZ) => v.z = newZ;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZ( ref V3I v, int newZ)  => v.z = newZ;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetZ( ref V4 v, float newZ) => v.z = newZ;

        // W
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static void SetW( ref V4 v, float newW) => v.w = newW;
#endif // Set

        // With[Axis]
        // X
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2 WithX(UV2 v, float newX) => new(newX, v.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2I WithX(UV2I v, int newX) => new(newX, v.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithX(UV3 v, float newX) => new(newX, v.y, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithX(UV3I v, int newX) => new(newX, v.y, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithX(UV4 v, float newX) => new(newX, v.y, v.z, v.w);

        // Y
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2 WithY(UV2 v, float newY) => new(v.x, newY);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2I WithY(UV2I v, int newY) => new(v.x, newY);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithY(UV3 v, float newY) => new(v.x, newY, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithY(UV3I v, int newY) => new(v.x, newY, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithY(UV4 v, float newY) => new(v.x, newY, v.z, v.w);

        // Z
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithZ(UV3 v, float newZ) => new(v.x, v.y, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithZ(UV3I v, int newZ) => new(v.x, v.y, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithZ(UV4 v, float newZ) => new(v.x, v.y, newZ, v.w);

        // W
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithW(UV4 v, float newW) => new(v.x, v.y, v.z, newW);

        // With[Axes]
        // XY
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithXY(UV3 v, float newX, float newY) => new(newX, newY, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithXY(UV3I v, int newX, int newY) => new(newX, newY, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXY(UV4 v, float newX, float newY) => new(newX, newY, v.z, v.w);

        // XZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithXZ(UV3 v, float newX, float newZ) => new(newX, v.y, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithXZ(UV3I v, int newX, int newZ) => new(newX, v.y, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXZ(UV4 v, float newX, float newZ) => new(newX, v.y, newZ, v.w);

        // YZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 WithYZ(UV3 v, float newY, float newZ) => new(v.x, newY, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3I WithYZ(UV3I v, int newY, int newZ) => new(v.x, newY, newZ);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithYZ(UV4 v, float newY, float newZ) => new(v.x, newY, newZ, v.w);

        // XW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXW(UV4 v, float newX, float newW) => new(newX, v.y, v.z, newW);

        // YW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithYW(UV4 v, float newY, float newW) => new(v.x, newY, v.z, newW);

        // ZW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithZW(UV4 v, float newZ, float newW) => new(v.x, v.y, newZ, newW);

        // XYZ
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXYZ(UV4 v, float newX, float newY, float newZ) => new(newX, newY, newZ, v.w);

        // XZW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithXZW(UV4 v, float newX, float newZ, float newW) => new(newX, v.y, newZ, newW);

        // YZW
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 WithYZW(UV4 v, float newY, float newZ, float newW) => new(v.x, newY, newZ, newW);


        // System.Numerics.Vector & UnityEngine.Vector
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SNV2 ToNumerics(UV2 v) => new SNV2(v.x, v.y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SNV3 ToNumerics(UV3 v) => new SNV3(v.x, v.y, v.z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static SNV4 ToNumerics(UV4 v) => new SNV4(v.x, v.y, v.z, v.w);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV2 ToUnity(SNV2 v) => new UV2(v.X, v.Y);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV3 ToUnity(SNV3 v) => new UV3(v.X, v.Y, v.Z);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static UV4 ToUnity(SNV4 v) => new UV4(v.X, v.Y, v.Z, v.W);
#endif // GRPU_VECS_EXTENSION
    }
}
