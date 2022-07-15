using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KompasTabl
{
    interface IForm1
    {
        //свойства класса
        string NameClas { get; set; }
        int choiseAbstractClas { get; set; }
        int accsesClad { get; set; }

        #region свойства значений        
        string NameValue1 { get; set; }
        int choiseAbstractValue1 { get; set; }
        int accsesValue1 { get; set; }

        string NameValue2 { get; set; }
        int choiseAbstractValue2 { get; set; }
        int accsesValue2 { get; set; }

        string NameValue3 { get; set; }
        int choiseAbstractValue3 { get; set; }
        int accsesValue3 { get; set; }

        string NameValue4 { get; set; }
        int choiseAbstractValue4 { get; set; }
        int accsesValue4 { get; set; }

        string NameValue5 { get; set; }
        int choiseAbstractValue5 { get; set; }
        int accsesValue5 { get; set; }
        #endregion свойства значений

        #region свойства конструктора
        string NameConstructor1 { get; set; }
        int choiseAbstractConstructor1 { get; set; }
        int accsesConstructor1 { get; set; }

        string NameConstructor2 { get; set; }
        int choiseAbstractConstructor2 { get; set; }
        int accsesConstructor2 { get; set; }

        string NameConstructor3 { get; set; }
        int choiseAbstractConstructor3 { get; set; }
        int accsesConstructor3 { get; set; }

        #endregion свойства конструктора

        #region свойства интерфейса
        string NameInterfeice1 { get; set; }
        int choiseAbstractInterfeice1 { get; set; }
        int accsesInterfeice1 { get; set; }

        string NameInterfeice2 { get; set; }
        int choiseAbstractInterfeice2 { get; set; }
        int accsesInterfeice2 { get; set; }

        string NameInterfeice3 { get; set; }
        int choiseAbstractInterfeice3 { get; set; }
        int accsesInterfeice3 { get; set; }

        string NameInterfeice4 { get; set; }
        int choiseAbstractInterfeice4 { get; set; }
        int accsesInterfeice4 { get; set; }

        string NameInterfeice5 { get; set; }
        int choiseAbstractInterfeice5 { get; set; }
        int accsesInterfeice5 { get; set; }

        string NameInterfeice6 { get; set; }
        int choiseAbstractInterfeice6 { get; set; }
        int accsesInterfeice6 { get; set; }

        string NameInterfeice7 { get; set; }
        int choiseAbstractInterfeice7 { get; set; }
        int accsesInterfeice7 { get; set; }

        string NameInterfeice8 { get; set; }
        int choiseAbstractInterfeice8 { get; set; }
        int accsesInterfeice8 { get; set; }

        string NameInterfeice9 { get; set; }
        int choiseAbstractInterfeice9 { get; set; }
        int accsesInterfeice9 { get; set; }

        string NameInterfeice10 { get; set; }
        int choiseAbstractInterfeice10 { get; set; }
        int accsesInterfeice10 { get; set; }
        #endregion свойства интерфейса

        //событие
        event EventHandler CreateTabl;
    }
}
