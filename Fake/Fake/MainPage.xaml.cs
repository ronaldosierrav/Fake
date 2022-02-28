using Fake.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Fake
{
    public partial class MainPage : TabbedPage
    {
        public ObservableCollection<Chats> Chats { get; set; }

        public ObservableCollection<Estados> Estados { get; set; }
        public ObservableCollection<Llamadas> Llamadas { get; set; }

        public ObservableCollection<Ajustes> Ajustes { get; set; }


        public MainPage()
        {
            InitializeComponent();

            Chats = new ObservableCollection<Chats>
            {
                new Chats {Nombre = "Harry", Image = "Profile1.png", Texto="Hace frio xd",Hora = "3:45PM"},
                new Chats {Nombre = "Tim", Image = "Profile2.png", Texto="Hola,Soy de nieve",Hora = "2:45PM"},
                new Chats {Nombre = "Cosmo", Image = "Profile3.png", Texto="Hola, Soy de galleta xd",Hora = "1:45PM"},
                new Chats {Nombre = "Fox", Image = "Profile4.jpg", Texto="Ola hijo",Hora = "12:45PM"},
                new Chats {Nombre = "Chica", Image = "Profile5.jpg", Texto="Brilla la estrella",Hora = "4:45AM"},
                new Chats {Nombre = "Regalo", Image = "Profile6.jpg", Texto="Regalo de navidad",Hora = "12:45AM"},
                new Chats {Nombre = "Chofer", Image = "Profile7.jpg", Texto="1.500 el pasaje",Hora = "3:45AM"},
            };


            Estados = new ObservableCollection<Estados>
            {
                new Estados {NombreEstado = "Fox" ,ImageEstado = "Profile4.png",Fecha = "Hoy 11:00 PM"},
                new Estados {NombreEstado = "Chofer" ,ImageEstado = "profile7.png",Fecha = "Hoy 10:00 PM"},
                new Estados {NombreEstado = "Tim" ,ImageEstado = "profile2.png",Fecha = "Hoy 9:30 PM"},
                new Estados {NombreEstado = "Regalo" ,ImageEstado = "Profile6.png",Fecha = "Hoy 4:45 PM"},
                new Estados {NombreEstado = "Chica" ,ImageEstado = "Profile5.png",Fecha= "Hoy 1:03 PM"},
                new Estados {NombreEstado = "Cosmo" ,ImageEstado = "Profile3",Fecha = "Hoy 6:12 AM"}


            };



            Llamadas = new ObservableCollection<Llamadas>
            {
                new Llamadas {NombreLlamada = "Tim", ImageLlamada = "Profile2.png", fecha = "26 Febrero", Hora ="9:00PM"},
                new Llamadas {NombreLlamada = "Cosmo", ImageLlamada = "Profile3.png", fecha = "26 Febrero", Hora ="9:00PM"},
                new Llamadas {NombreLlamada = "Regalo", ImageLlamada = "Profile6.png", fecha = "26 Febrero", Hora ="9:00PM"}
            };

            Ajustes = new ObservableCollection<Ajustes>
            {
                new Ajustes {NombreAjuste = "Ronaldo Sierra", ImageAjuste ="profileAjus.png",Texto = "zzz"},
                new Ajustes {NombreAjuste = "Cuenta", ImageAjuste ="llave.png",Texto = "Privacidad,Seguridad,Cambiar Número"},
                new Ajustes {NombreAjuste = "Chats", ImageAjuste ="comentario.png",Texto = "Tema,Fondo de pantalla, historial de chats"},
                new Ajustes {NombreAjuste = "Notificaciones", ImageAjuste ="campana.png",Texto = "Tonos de mensajes, Grupos Y Llamadas"},
                new Ajustes {NombreAjuste = "Almacenamiento", ImageAjuste ="carpeta.png",Texto = "Uso de Red, Descarga Automatica"},
                new Ajustes {NombreAjuste = "Invitar Amigos", ImageAjuste ="usuario.png",}
            };
            this.BindingContext = this;
        }

            
            



        private void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String previus = (e.PreviousSelection.FirstOrDefault() as Chats)?.Nombre;
            String current = (e.CurrentSelection.FirstOrDefault() as Chats)?.Nombre;
        }

        private void CollectionView_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            String previus = (e.PreviousSelection.FirstOrDefault() as Ajustes)?.NombreAjuste;
            String current = (e.CurrentSelection.FirstOrDefault() as Ajustes)?.NombreAjuste;
        }

        private void CollectionView_SelectionChanged_2(object sender, SelectionChangedEventArgs e)
        {
            String previus = (e.PreviousSelection.FirstOrDefault() as Estados)?.NombreEstado;
            String current = (e.CurrentSelection.FirstOrDefault() as Estados)?.NombreEstado;
        }
    

        private void CollectionView_SelectionChanged_3(object sender, SelectionChangedEventArgs e)
        {
            String previus = (e.PreviousSelection.FirstOrDefault() as Llamadas)?.NombreLlamada;
            String current = (e.CurrentSelection.FirstOrDefault() as Llamadas)?.NombreLlamada;
        }

    }
}
