﻿using System;

namespace MonoMod {
    [MonoModIgnore]
    /// <summary>
    /// MonoMod ignore attribute.
    /// Apply it onto a method / type and it will be ignored by MonoMod.
    /// </summary>
    public class MonoModIgnore : Attribute {
    }
}

