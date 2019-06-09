using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangulo
{
    public class ClassRectangulo : INotifyPropertyChanged
    {
        //Variables miembtro
        private string X1;
        private string X2;
        private string Y1;
        private string Y2;
        private string Area;
        private string Distancia;
        private string Perimetro;

        //Propiedades
        public string x1
        {
            get { return X1; }
            set
            {
                bool Area = int.TryParse(value, out int numero);
                if (Area) X1 = value;
                OnPropertyChanged("X1");
                OnPropertyChanged("Area");
            }
        }

        public string x2
        {
            get { return X2; }
            set
            {
                bool area = int.TryParse(value, out int numero);
                if (area) X2 = value;
                OnPropertyChanged("X2");
                OnPropertyChanged("Area");
            }
        }

        public string y1
        {
            get { return Y1; }
            set
            {
                bool Area = int.TryParse(value, out int numero);
                if (Area) Y1 = value;
                OnPropertyChanged("Y1");
                OnPropertyChanged("Area");
            }
        }

        public string y2
        {
            get { return Y2; }
            set
            {
                bool Area = int.TryParse(value, out int numero);
                if (Area) Y2 = value;
                OnPropertyChanged("Y2");
                OnPropertyChanged("Area");
            }
        }

        public string area
        {
            get
            {
                int Area = int.Parse(x1) * int.Parse(y1);
                return Area.ToString();
            }
            set
            {
                int mult = int.Parse(x1) * int.Parse(y1);
                Area = mult.ToString();
                OnPropertyChanged("Area");
            }
        }

        public string distangia
        {
            get {
                int Distancia = ((int.Parse(x2) - int.Parse(x1)) ^ 2- (int.Parse(y2)-int.Parse(x1))^2)^1/2;
                return Distancia.ToString();
            }
            set {
                int dis= ((int.Parse(x2) - int.Parse(x1)) ^ 2 - (int.Parse(y2) - int.Parse(x1)) ^ 2) ^ 1 / 2;
                Distancia = dis.ToString();
                OnPropertyChanged("Distancia");
            }
                
                }
        public string perimetro
        {
            get
            {
                int Perimetro = (2*(int.Parse(x1)))+ (2*int.Parse(y2));
                return Perimetro.ToString();
            }
            set
            {
                int per = (2 * (int.Parse(x1))) + (2 * int.Parse(y1));
                Distancia = per.ToString();
                OnPropertyChanged("Perimetro");
            }

        }
        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property)); 
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
