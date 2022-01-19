using System;

namespace RPG
{
    [Serializable]
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException() {}

        public InvalidWeaponException(string message) : base(message) { }

        public InvalidWeaponException(string message, Exception inner) : base(message, inner) { }
    }

    [Serializable]
    public class InvalidArmourException : Exception
    {
        public InvalidArmourException() {}

        public InvalidArmourException(string message) : base(message) { }

        public InvalidArmourException(string message, Exception inner) : base (message, inner) { }
    }
}
