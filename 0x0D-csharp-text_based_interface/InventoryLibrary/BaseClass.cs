using System;

namespace InventoryLibrary
{
    /// <summary> BaseClass to inherit from </summary>
    public class BaseClass
    {
        /// <summary> id of the object </summary>
        public string id{get; set;}
        /// <summary> date when object was created </summary>
        public DateTime date_created{get; set;}
        /// <summary> date when object was updated </summary>
        public DateTime date_updated{get; set;}
    }
}
