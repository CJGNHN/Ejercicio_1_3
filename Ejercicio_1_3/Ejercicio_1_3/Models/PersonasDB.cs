using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using Ejercicio_1_3;
using System.Threading.Tasks;
using Ejercicio_1_3.Models;

namespace Ejercicio_1_3.Models
{
    public class PersonasDB
    {
        readonly SQLiteAsyncConnection db;

        //CONSTRUCTOR DE CLASE VACIO
        public PersonasDB()
        {
            
        }
        //CONSTRUCTOR CON PAREMTROS
        public PersonasDB(String pathbasedatos)
        {
            db = new SQLiteAsyncConnection(pathbasedatos);

            //CREACION DE TABLAS DB
            db.CreateTableAsync<Personas>();
        }

        //PROCEDIMIENTOS Y FUNCIONES

        public Task<List<Personas>> ListaPersonas()
        {
            return db.Table<Personas>().ToListAsync();
        }

        //BUSCAR EMPLEADO POR CODIGO
        public Task<Personas> BuscarPersonas(Int32 pcodigo)
        {
            return db.Table<Personas>().Where(i => i.codigo == pcodigo).FirstOrDefaultAsync();
        }

        //Guardar o Actualizar empleados
        public Task<Int32> GuardarPersonas(Personas perso)
        {
            if (perso.codigo != 0)
            {
                return db.UpdateAsync(perso);
            }
            else
            {
                return db.InsertAsync(perso);
            }
        }

        //ELIMINAR EMPLEADO ESPECIFICO
        public Task<Int32> ElimininarPersonas(Personas perso)
        {
            return db.DeleteAsync(perso);
        }

    }


}
