﻿using System;

namespace UnrealEngine
{
    public abstract class NativeWrapper
    {
        protected IntPtr NativePointer;

        protected NativeWrapper(IntPtr Adress)
        {
            NativePointer = Adress;
        }
    }
}