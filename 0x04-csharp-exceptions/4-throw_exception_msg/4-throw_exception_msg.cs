﻿using System;

    class Except
    {
        public static void ThrowMsg(string msg)
        {
            throw new ArrayTypeMismatchException(msg);
        }
    }
