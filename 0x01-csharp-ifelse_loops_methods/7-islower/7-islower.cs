using System;

class Character
{
    public static bool IsLower(char c){
        if ((byte)c >= 97 && (byte)c <= 122){
            return true;
        }else {
            return false;
        }
    }
}
