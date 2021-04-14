﻿namespace Msi.Data.Entity
{
    [IgnoredEntity]
    public class RootEntity<T> : IEntity, IGenericEntity<T>
    {
        public T Id { get; set; }
        //public bool IsDeleted { get; set; }
    }
}
