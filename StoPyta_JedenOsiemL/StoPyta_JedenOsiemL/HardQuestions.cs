using System;
using System.Collections.Generic;
using System.Text;

namespace StoPyta_JedenOsiemL
{
    public class HardQuestions
    {
        private const int x = 75;
        private List<String> __questMaster;
        private LinkedList<String> __questShake;
        private int Randomness = 1;
        private Random randGen = new Random();

        public HardQuestions()
        {
            __questMaster = new List<String>(new String[x]
            {
                "Czy masz jakiś fetysz? Jeżeli tak, to jaki?",
                "Wymień jedną seksualną fantazję, której nie zrealizowałeś.",
                "Czego się krępujesz w sferze seksu?",
                "Co byłoby seksualną przesadą?",
                "Czy mógłbyś wziąć udział w trójkącie?",
                "Gdybyś mógł uprawiać seks w dowolnym miejscu na Ziemi, gdzie by to było?",
                "Jaki ubiór Cię szczególnie podnieca?",
                "Jakich erotycznych zabawek chciałbyś spróbować?",
                "Najlepszy alkohol podczas wspólnego wieczoru to...?",
                "Jak wyobrażasz sobie idealną grę wstępną?",
                "Lepszy romantyczny stosunek, czy walka o dominację?",
                "Wymień swoje najwrażliwsze miejsca na ciele.",
                "W jakich godzinach masz największą ochotę?",
                "Co sądzisz o uprawianiu seksu do muzyki?",
                "Jak najbardziej lubisz, aby Twoje miejsca intymne były pieszczone?",
                "Ręką, czy ustami? Dlaczego?",
                "W pierwszej kolejności lepiej zaspokoić partnera, czy być zaspokojonym?",
                "Co seksownego chciałbyś usłyszeć od drugiej osoby?",
                "Co chciałbyś, aby druga osoba z Tobą zrobiła?",
                "Czy mógłbyś uprawiać seks do lecącego w tle porno?",
                "Co chciałbyś ulepszyć w swoim życiu seksualnym?",
                "Czy byłbyś w stanie uprawiać seks w miejscu publicznym?",
                "Na co masz teraz ochotę?",
                "Jaka jest Twoja ulubiona pozycja?",
                "Który zapach jest najbardziej podniecający?",
                "Czy miałeś kiedyś orgazm będąc w ubraniu?",
                "Czy jesteś głośno podczas seksu?",
                "Powiedz o czymś, co lubisz robić podczas seksu.",
                "Co Cię najbardziej podnieca podczas seksu?",
                "Lepszy seks oralny, czy zwykły?",
                "Co uważasz o seksie analnym?",
                "Jak zareagowałbyś, gdybyś został przyłapany na seksie?",
                "Czy byłbyś w stanie uprawiać seks z osobą tej samej płci?",
                "Czy podnieca Cię, jak druga osoba się przy Tobie masturbuje?",
                "Czy byłbyś w stanie wysłać komuś swoje nagie zdjęcia?",
                "Czy rozmiar ma dla Ciebie znaczenie?",
                "Jak najszybciej osiągasz orgazm?",
                "Czy lubisz jak w trakcie seksu druga osoba zjada Cię wzrokiem?",
                "Jakie porno podnieca Cię najbardziej?",
                "Co sądzisz o BDSM?",
                "Jaki jest najlepszy sposób, żeby zaciągnąć kogoś do łóżka?",
                "Gdybyś miał opisać dobry seks jednym słowem, to jakim?",
                "Co uważasz o seksie w aucie?",
                "Opisz jak byś to robił w osiedlowym parku, tak aby nikt nie zauważył.",
                "Jaki jest idealny rozmiar piersi?",
                "Jaki jest najlepszy rodzaj antykoncepcji?",
                "Czy kręcą Cię roleplay'e? Jeżeli tak, to w jaką postać chciałbyś się wcielić?",
                "Na jakim miejscu na ciele najlepiej dojść?",
                "Jaki jest najlepszy widok szczytującego partnera?",
                "Lubisz podduszanie i ciągnięcie za włosy, czy jest to brak szacunku?",
                "Co sądzisz o kobiecej dominacji?",
                "Jakie subtelne gesty podniecają Cię najbardziej?",
                 "Czy są dni, w których masz większą ochotę niż zwykle? Od czego to zależy?",
                "Gdybyś miał na zawsze zrezygnować z jednej seksualnej pozycji to z jakiej?",
                 "Ile czasu byłbyś w stanie wytrzymać bez seksu?",
                "Jakiego seksualnego zachowania osób Twojej płci szczególnie nie tolerujesz?",
                "Jak często myślisz o seksie?",
                "Jak wyglądałby Twój wymarzony pokój zabaw?",
                "Połykać, czy wypluwać?",
                "Co myślisz o seksie bez zabezpieczenia?",
                "Czy miewasz fantazje, że robisz to z kimś pomimo Twojej woli?",
                "Czy miewasz fantazje o uprawianiu seksu z kimś kto śpi?",
                "Lateks - hot or not?",
                "Czy podnieciło by Cię zaspokojenie partnera bez zrewanżowania?",
                "Jakie miejsca partnera najchętniej pieściłbyś językiem/ustami?",
                "Czy mówisz, że właśnie dochodzisz?",
                "Czy zdarza Ci się udawać orgazm?",
                "Czy boisz się, że usłyszą Cię sąsiedzi?",
                "Lubisz bezwstydny, dziki seks?",
                "Czy myślisz podczas seksu o tym jak wyglądasz?",
                "Czy zdarza Ci się myśleć podczas seksu o czymś innym?",
                "Czy chciałbyś zagrać w rozbieranego pokera?",
                "Co seksownego chciałbyś dostać w prezencie?",
                "Pod prysznicem, czy w wannie?",
                "Najseksowniejsza bielizna?",
            });

            __questShake = MakeRandomList();
        }

        private LinkedList<String> MakeRandomList()
        {
            if (__questShake == null) __questShake = new LinkedList<string>();
            List<String> copy = new List<string>(__questMaster);

            for (int k = 0; k < Randomness; ++k)
            {
                for (int i = 0; i < copy.Count; ++i)
                {
                    int randIdx = randGen.Next() % copy.Count;
                    //zamiana elementów
                    String pom = copy[i];
                    copy[i] = copy[randIdx];
                    copy[randIdx] = pom;
                }
            }
            foreach (var Var in copy)
                __questShake.AddFirst(Var);
            return __questShake;
        }

        public String GetRandomQuestion()
        {
            String question;
            if (__questShake == null || __questShake.Count < 1)
                __questShake = MakeRandomList();
            question = __questShake.First.Value;
            __questShake.RemoveFirst();
            return question;
        }
    }
}
