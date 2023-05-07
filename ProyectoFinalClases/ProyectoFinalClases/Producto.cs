using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalClases
{
    public class Producto
    {

        #region Atributos

        private int _id;
        private string _descripcion;
        private double _costo;
        private double _precioventa;
        private double _stock;
        private int _idusuario;

        #endregion

        #region Propiedades

        public int Id
        {
            get { return this._id; }
        }

        public string Descripcion
        {
            get { return this._descripcion; }
            set { this._descripcion = value; }
        
        }

        public double Costo 
        {
            get { return this._costo; }
            set { this._costo = value; }
        }

        public double Precioventa
        {
            get { return this._precioventa;}
            set { this._precioventa = value;}
        }
        
        public double Stock
        {
            get { return this._stock; }
            set { this._stock = value; }
        }

        public int IdUsuario 
        {
            get { return this._idusuario; }
            set { this._idusuario = value; }
        }

        #endregion

        #region Constructores

        public Producto(int id, string descripcion, double costo, double precioventa, double stock, int idusuario)
        {
            _id = id;
            _descripcion = descripcion;
            _costo = costo;
            _precioventa = precioventa;
            _stock = stock;
            _idusuario = idusuario;
        }

        #endregion

    }
}
