﻿using System;
using System.Collections.Generic;
using System.Text;

namespace IterativeRotationCipher
{
    public class Decoder
    {
        public object Decode(string phrase, int number_rotations)
        {
            phrase =  phrase.Substring(number_rotations) + phrase.Substring(0, number_rotations);
            return phrase.Substring(number_rotations) + phrase.Substring(0, number_rotations);
        }
    }
}
