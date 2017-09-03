﻿using System.Data.Common;

namespace SimpleNet.Core.Data.Mappers
{
    /// <summary>
    /// Interface to map SimpleRowMapper   <typeparamref name="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRowMapper<out T>
    {
        T MapRow(DbDataReader record);
    }

}
