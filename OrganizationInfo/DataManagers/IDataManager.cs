﻿using System.Collections.Generic;

namespace OrganizationInfo
{
    // TODO: комментарии
    public interface IDataManager<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        void Add(T obj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        void Delete(T obj);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        void Update(T obj);

        // TODO: тут надо просто int Id передавать

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Get(IdInformation Ids);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        List<T> GetAll();
    }
}
