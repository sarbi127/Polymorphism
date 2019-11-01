using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift_3
{
    abstract class UserError
    {
        public abstract string UEMessage();
    }

    class NumericInputError : UserError
    {
        public override string UEMessage() 
        {
            return $"You tried to use anumeric input in a text only field. This fired an error!";
        }

    }

    class TextInputError : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a textinput in a numericonly field. This fired an error!";
        }
    }
    class TextInputError2 : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a textinput in a numericonly1 field. This fired an error!";
        }
    }
    class TextInputError3 : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a textinput in a numericonly2 field. This fired an error!";
        }
    }

    class TextInputError4 : UserError
    {
        public override string UEMessage()
        {
            return $"You tried to use a textinput in a numericonly3 field. This fired an error!";
        }
    }
}
