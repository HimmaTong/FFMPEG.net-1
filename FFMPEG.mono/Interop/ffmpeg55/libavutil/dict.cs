/*
 * copyright (c) 2013 Crazyender
 *
 * This file is part of FFmpeg.mono
 *
 * FFmpeg.mono is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * FFmpeg.mono is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with FFmpeg; if not, write to the Free Software
 * Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA 02110-1301 USA
 */


using System;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Security;
namespace SharpFFmpeg
{
    public partial class AV 
{
		#if WIN32
		public const string DICT = "avutil-52.dll";
		#else
		public const string DICT = "avutil";
		#endif

public static readonly uint AV_DICT_MATCH_CASE = 1;
public static readonly uint AV_DICT_IGNORE_SUFFIX = 2;
public static readonly uint AV_DICT_DONT_STRDUP_KEY = 4;
public static readonly uint AV_DICT_DONT_STRDUP_VAL = 8;
public static readonly uint AV_DICT_DONT_OVERWRITE = 16;
public static readonly uint AV_DICT_APPEND = 32;
[DllImport(DICT), SuppressUnmanagedCodeSecurity]
public static extern IntPtr/* AVDictionaryEntry*  */ av_dict_get(
	IntPtr/* AVDictionary*  */ m, 
	[MarshalAs(UnmanagedType.LPStr)]
	string key, 
	IntPtr/* AVDictionaryEntry*  */ prev, 
	[MarshalAs(UnmanagedType.I4)]
	System.Int32 flags);

[DllImport(DICT), SuppressUnmanagedCodeSecurity]
public static extern System.Int32 av_dict_count(
	IntPtr/* AVDictionary*  */ m);

[DllImport(DICT), SuppressUnmanagedCodeSecurity]
public static extern System.Int32 av_dict_set(
	IntPtr/* IntPtr*  */ pm, 
	[MarshalAs(UnmanagedType.LPStr)]
	string key, 
	[MarshalAs(UnmanagedType.LPStr)]
	string value, 
	[MarshalAs(UnmanagedType.I4)]
	System.Int32 flags);

[DllImport(DICT), SuppressUnmanagedCodeSecurity]
public static extern System.Int32 av_dict_parse_string(
	IntPtr/* IntPtr*  */ pm, 
	[MarshalAs(UnmanagedType.LPStr)]
	string str, 
	[MarshalAs(UnmanagedType.LPStr)]
	string key_val_sep, 
	[MarshalAs(UnmanagedType.LPStr)]
	string pairs_sep, 
	[MarshalAs(UnmanagedType.I4)]
	System.Int32 flags);

[DllImport(DICT), SuppressUnmanagedCodeSecurity]
public static extern void av_dict_copy(
	IntPtr/* IntPtr*  */ dst, 
	IntPtr/* AVDictionary*  */ src, 
	[MarshalAs(UnmanagedType.I4)]
	System.Int32 flags);

[DllImport(DICT), SuppressUnmanagedCodeSecurity]
public static extern void av_dict_free(
	IntPtr/* IntPtr*  */ m);

public struct AVDictionaryEntry{
	[MarshalAs(UnmanagedType.LPStr)]
	public string key;

	[MarshalAs(UnmanagedType.LPStr)]
	public string value;

};

}
}

