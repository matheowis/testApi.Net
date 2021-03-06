﻿using ServiceStack;
using ServiceStack.OrmLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using testAPI.Models;

namespace testAPI.Repository
{
    public class UserRepository:Service
    {
        public List<Person> GetPeople()
        {
            return Db.Select<Person>().ToList();
        }

        public Person GetById(int id)
        {
            return Db.SingleById<Person>(id);
        }

    }
}
