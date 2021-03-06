﻿using System.Collections.Generic;

namespace CMS.DataAccess
{
    public interface IDataAccessor
    {
        int Execute(string storedProcName, object param = null);

        IEnumerable<T> Query<T>(string storedProcName, object param = null);
        T QuerySingle<T>(string storeProcName, object param = null);
    }
}