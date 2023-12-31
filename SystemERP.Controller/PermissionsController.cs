﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemERP.Data;
using SystemERP.Model;

namespace SystemERP.Controller
{
    public class PermissionsController
    {
        PermissionsData data = new PermissionsData();
        List<Permissions> permissions = new List<Permissions>();
        List<Permissions> activeListPermi = new List<Permissions>();
        public int CreatePermission(string descripcion)
        {
            if (string.IsNullOrEmpty(descripcion))
            {
                return 0;
            }
            return data.CreatePermission(new Model.Permissions() { Description = descripcion });    
        }

        public bool DeletePermission(int id)
        {
            if(id <= 0)
            {
                return false;
            }
            return data.DeletePermission(new Model.Permissions() { Id = id });
        }
        
        public bool UpdatePermission(int id, string descripcion, int state)
        {
            if (id <= 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(descripcion)) { return false; }
            if (state < 0) { return false; } 
            return data.UpdatePermission(new Model.Permissions() { Id=id, Description= descripcion, State = state });
        }

        public IEnumerable<Permissions> GetAll()
        {            
            return data.GetAll();
        }
        
        public bool AddPermissionToList(Permissions permission)
        {            
            if(!permissions.Any(item => item.Description == permission.Description)){
                permissions.Add(permission);
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Permissions> GetPermissionsList()
        {
            return permissions;
        }
        
        public void RemoveToListById(int id)
        {
            permissions.RemoveAt(id);
        }

        public void ClearListAux()
        {
            permissions.Clear();
        }

        public void SetList()
        {
            activeListPermi = GetAll().ToList();
        }

        public void SetList(List<Permissions> permi)
        {
            activeListPermi = permi.ToList();
        }

        public List<Permissions> GetList()
        {
            return activeListPermi;
        }
    }
}
