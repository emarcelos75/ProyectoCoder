using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalClases
{
    public class Venta
    {
        #region Atributos

        private int _id;
        private string _comentarios;
        private int _idusuario;

        #endregion

        #region Propiedades

        public int Id 
        { 
            get { return _id; } 
            set { _id = value; } 
        }

        public string Comentarios
        {
            get { return this._comentarios; }
            set { this._comentarios = value; }
        }

        public int IdUsuario 
        { 
            get { return _idusuario; } 
            set { _idusuario = value; } 
        }

        #endregion

        #region Constructor

        public Venta(int id, string comentarios, int idusuario)
        {
            _id = id;
            _comentarios = comentarios;
            _idusuario = idusuario;
        }


        #endregion



    }
}
