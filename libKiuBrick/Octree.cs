﻿#region License
/*
The MIT License (MIT)

Copyright (c) 2013 Textquell

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
#endregion

#region Abstract

#endregion

namespace Textquell.KiuBrick.Octrees
{
    using System;

    /// <summary>
    /// A generic octree class to store data in
    /// </summary>
    public class Octree<T>
    {
        public class VoxelNode
        {
            /// <summary>
            /// valid mask tells whether each of the child slots actually contains a voxel
            /// </summary>
            byte _validmask;
            /// <summary>
            /// leaf mask further speciﬁes whether each of these voxels is a leaf
            /// </summary>
            byte _leafmask;
            /// <summary>
            /// stores a pointer to the next child of the parent node, thus aligning the memory 
            /// sequentially
            /// </summary>
            VoxelNode neighbor;
            /// <summary>
            /// keeps a pointer to the first child. Pointing downwards the tree allows for arbitrary root
            /// nodes and insertion at the top of the tree
            /// </summary>
            VoxelNode firstChild;
        }
    }
}