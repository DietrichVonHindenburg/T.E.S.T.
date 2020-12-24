using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_Advenuture
{
    class Program
    {
        static void Main(string[] args)
        {
            bool eingabegueltig = false;
            string name = "";
            bool siechtum = false;

            string[] moeglichkeiten;
            string eingabe = "";
            int eingabeInt = 0;
            bool usePassword = false;
            bool spielen = true;
            bool hasAdvanced = false;

            int characterWait = 35;
            int randomWait = 7;
            int startCharacterWait = characterWait;
            int startRandomWait = randomWait;

            Random random = new Random();

            characterWait = 1;
            randomWait = 0;

            write(@"
 ____o__ __o____    o__ __o__/_          o__ __o      ____o__ __o____ 
  /   \   /   \    <|    v              /v     v\      /   \   /   \  
       \o/         < >                 />       <\          \o/       
        |           |                 _\o____                |        
       < >          o__/_                  \_\__o__         < >       
        |           |                            \           |        
        o      o   <o>            o    \         /    o      o        
       <|     <|>   |            <|>    o       o    <|>    <|        
       / \    < >  / \  _\o__/_  < >    <\__ __/>    < >    / \       
Text-Adventure mit Eloquenz     und     superben        Tiraden
");

            //Console.ReadLine();

            if (usePassword)
            {
                write("Wie lautet das Passwort?");
                eingabeBekommen();
            }
            if (!usePassword || eingabe == "Was für ein Passwort? Warum sollte dieses Programm ein Passwort haben?".ToUpper())
            {
                //characterWait = 5;
                //randomWait = 0;

                //System.Threading.Thread.Sleep(1000);
                characterWait = startCharacterWait;
                randomWait = startRandomWait;

                write("Du startest das Spiel und siehst einen sehr ansprechenden Titelbildschirm.\n" +
                    "Du bewunderst den Titel des Spiels und die Kreativität, aus dem Namen ein Akronym zu machen.\n" +
                    "Außerdem fällt dir auf, wie clever diese Meta-Kommentare sind.\n" +
                    "Nachdem du einige Momente staunst, realisierst du, dass das zwar unglaublich interessant und intelligent ist, du aber endlich spielen möchtest.\n" +
                    "\n" +
                    "<forfahren>");
                eingabeBekommen();
                //Music.playRickRoll();
                //{
                //    System.Threading.Thread thread = new System.Threading.Thread(Music.playPreußen);
                //    thread.Start();
                //}

                while (!eingabegueltig)
                {
                    write("\nSo nenne er/sie/es mir seinen Namen:");
                    name = Console.ReadLine().Trim();
                    write("Ist {0} korrekt?", name);
                    eingabe = Console.ReadLine().ToUpper().Trim();
                    if ((new string[] { "JA", "NEIN" }).Contains(eingabe))
                    {
                        eingabegueltig = eingabe == "JA";
                    }
                }
                if (name.ToUpper() == "CORONA")
                    write("sehr humorvoll");
                eingabegueltig = false;

                while (!eingabegueltig)
                {
                    while (!eingabegueltig)
                    {
                        write("\nEntspricht ein Epos über ein Siechtum den Ihrigen Präferenzen?");
                        eingabe = Console.ReadLine().ToUpper().Trim();
                        if ((new string[] { "JA", "NEIN" }).Contains(eingabe))
                        {
                            eingabegueltig = true;
                            siechtum = eingabe == "JA";
                        }
                    }

                    if (siechtum)
                    {
                        #region siechtum
                        string erreger = "";
                        eingabegueltig = false;

                        long gesund = 8000000000;
                        long krank = 0;
                        long tot = 0;
                        long infizierteLaender = 0;
                        double ansteckungsrate = 0;
                        double mutationsrate = 0;
                        double heilmittel = 0;
                        double heilmittelIncr = 0;

                        while (!eingabegueltig)
                        {
                            while (!eingabegueltig)
                            {
                                write("Bitte wählen Sie ihre Siechtum:\n");
                                List<string> erregerlist = new List<string> { "VIRUS", "BAKTERIUM" };
                                foreach (string s in erregerlist)
                                {
                                    write(s);
                                }
                                eingabe = Console.ReadLine().ToUpper();
                                if (erregerlist.Contains(eingabe))
                                {
                                    eingabegueltig = true;
                                    erreger = eingabe;
                                }
                            }
                            eingabegueltig = false;

                            switch (erreger)
                            {
                                case "VIRUS":
                                    write("Viren haben eine hohe Mutationsrate.");
                                    ansteckungsrate = 1.1;
                                    mutationsrate = 0.2;
                                    break;
                                case "BAKTERIUM":
                                    write("Bakterien sind LANGWEILIG.");
                                    ansteckungsrate = 3.2;
                                    mutationsrate = 0.0001;
                                    break;
                            }
                            write("Sind Sie sich sicher?");
                            eingabe = Console.ReadLine().ToUpper();
                            if ((new string[] { "JA", "NEIN" }).Contains(eingabe))
                            {
                                eingabegueltig = eingabe == "JA";
                                if (eingabegueltig && erreger == "BAKTERIUM")
                                {
                                    write("Nein, Bakterien sind langweilig.");
                                    eingabegueltig = false;
                                }
                            }
                        }
                        eingabegueltig = false;
                        void printStatus()
                        {
                            write("\nGesund: " + gesund + " | Krank: " + " | Tot: {2}\n", gesund, krank, tot);
                        }

                        Console.Clear();

                        while (!eingabegueltig)
                        {
                            printStatus();
                            write("Du bist {0}, ein {1}. Welches Land möchtest du infizieren?", name, erreger);

                            moeglichkeiten = new string[] { "USA", "CHINA" };
                            writeChoices(moeglichkeiten);
                            eingabeInt = evaluate(moeglichkeiten, Console.ReadLine());
                            if (eingabeInt != 0)
                            {
                                eingabegueltig = true;
                                eingabe = "USA";
                            }
                        }
                        #endregion
                    }
                    else
                    {
                        eingabegueltig = false;
                        while (!eingabegueltig)
                        {
                            write("Wie wäre es mit einem Ausschnitt aus dem auf \"Steam\" verfügbaren Spiel \"Pony Island\"");
                            eingabeBekommen();
                            if (new string[] { "JA", "NEIN" }.Contains(eingabe))
                            {
                                eingabegueltig = true;
                            }
                        }
                        if (eingabe == "JA")
                        {
                            #region Pony Island
                            bool startmenueRepariert = false;
                            Console.Clear();
                            write("Dunkelheit\nEin Schimmer Licht\nEin großer Stern schmückt den staubigen Bildschirm.\n" +
                                "'Systemtech Incorporated' steht dort geschrieben.\n" +
                                "<fortfahren>?");
                            Console.ReadLine();
                            write("Ein ansprechendes Menü erscheint\n" +
                                "Zwei schöne Ponys begleitet von einem Text: 'Pony Island'");

                            eingabegueltig = false;
                            while (!eingabegueltig)
                            {
                                write("\nDie Menü-Buttons sehen vielversprechend aus\n" +
                                "<Starte Spiel> lautet einer.\n" +
                                "<Optionen> lautet ein anderer.\n" +
                                "<Credits> lautet der letzte.");

                                while (!eingabegueltig)
                                {
                                    eingabeBekommen();
                                    if (eingabe.Contains("CRE") || eingabe.Contains("OPT") || eingabe.Contains("SPIEL"))
                                        eingabegueltig = true;
                                }
                                eingabegueltig = false;
                                if (eingabe.Contains("CRE"))
                                {
                                    write("\n\nWährend die Credits vorbeifliegen, fühlst du Ehrfurcht.\n" +
                                        "Ein Name hebt sich klar von Rest ab…\n" +
                                        "Du kehrst mit einer neu entdeckten Wertschätzung für Entwickler in das Menü zurück.");
                                }
                                else if (eingabe.Contains("OPT"))
                                {
                                    write("\n\nEine große Reihe an Optionen wird dir angezeigt.");
                                    List<string> optionen = new List<string> { "Anti-Aliasing", "Fröhliche Fassade", "Verbesserter RNG", "Kostenloses Ticket", "Pony-Physik", "Repariere Start-Menü", "In-App-Käufe", "1010011010", "Obskure Optionen", "*Schneemann*" };
                                    foreach (string s in optionen)
                                        write("<" + s + ">");
                                    write("Und ein <Zurück> Button zum Schließen.");
                                    optionen.Add("Zurück");
                                    eingabegueltig = false;
                                    while (!eingabegueltig)
                                    {
                                        while (!eingabegueltig)
                                        {
                                            eingabeBekommen();
                                            if (eingabe.Length > 3)
                                            {
                                                bool found = false;
                                                foreach (string s in optionen)
                                                    if (s.ToUpper().Contains(eingabe))
                                                    {
                                                        found = true;
                                                        break;
                                                    }
                                                if (found)
                                                    eingabegueltig = true;
                                            }
                                        }
                                        eingabegueltig = false;
                                        foreach (string s in optionen)
                                        {
                                            if (s == "Repariere Start-Menü")
                                                if (eingabe.Contains("REPA"))
                                                {
                                                    startmenueRepariert = true;
                                                    write("Du klickst auf die Option und es piept. Aber was hat es gemacht?");
                                                }
                                                else { }
                                            else if (s == "Zurück")
                                            {
                                                if (eingabe.Contains("ZURÜ"))
                                                    eingabegueltig = true;
                                            }
                                            else if (s == "*Schneemann*")
                                                if (eingabe.Contains("SCHN"))
                                                    write("<Fehler>");
                                                else { }
                                            else if (s == "1010011010")
                                                if (eingabe.Contains("1010"))
                                                    write("<Fehler>");
                                                else { }
                                            else
                                            {
                                                if (s.ToUpper().Contains(eingabe))
                                                {
                                                    write("Du klickst auf die Option… Es piept, aber es passiert nichts.");
                                                }
                                            }

                                        }
                                    }
                                    eingabegueltig = false;
                                }
                                else if (eingabe.Contains("SPIEL"))
                                {
                                    if (!startmenueRepariert)
                                        write("<Fehler>");
                                    else
                                    {
                                        void prompt()
                                        {
                                            write("Wirst du <Springen>, <Schießen> oder <Nichts tun>");
                                        }
                                        bool valid()
                                        {
                                            return new string[] { "SPRINGEN", "SCHIEßEN", "NICHTS TUN" }.Contains(eingabe);
                                        }
                                        write("\n\nEin Ladebildschirm erscheint.\n" +
                                            "Glücklicherweise ist es ein gut programmierter Ladebildschirm.\n" +
                                            "Es lädt sehr schnell.\n" +
                                            "Sehr schnell\n" +
                                            "Das Spiel ist geladen und du bist ein Pony.\n" +
                                            "Eine wunderschöne Sonne geht über perfekte, grüne Hügel unter.\n" +
                                            "Du fühlst den Wind durch deine Mähne wehen, während du über das grasige Tal galoppierst.\n" +
                                            "Sieh da! Ein hölzernes Tor nähert sich.");
                                        prompt();
                                        do
                                        {
                                            eingabeBekommen();
                                        }
                                        while (!valid());
                                        if (eingabe != "SPRINGEN")
                                        {
                                            write("Du rennst in das Tor. Die Splitter graben sich tief in deine Schienbeine und du bereust, deinen Stall verlassen zu haben. Alles vor deinen Augen wird schwarz.");
                                        }
                                        else
                                        {
                                            write("Du springst majästetisch über das Tor.\n" +
                                                "Aber ein weiteres Tor nähert sich!");
                                            prompt();
                                            do
                                            {
                                                eingabeBekommen();
                                            }
                                            while (!valid());
                                            if (eingabe != "SPRINGEN")
                                            {
                                                write("Du rennst in das Tor. Die Splitter graben sich tief in deine Schienbeine und du bereust, deinen Stall verlassen zu haben. Alles vor deinen Augen wird schwarz.");
                                            }
                                            else
                                            {
                                                write("Du meisters den Sprung und rennst weiter.\n" +
                                                    "Nun nähert sich ein Gegner.");
                                                prompt();
                                                do
                                                {
                                                    eingabeBekommen();
                                                }
                                                while (!valid());
                                                if (eingabe != "SCHIEßEN")
                                                {
                                                    write("Der Gegner springt gegen dich und tötet sich dabei. Alles vor deinen Augen wird schwarz.");
                                                }
                                                else
                                                {
                                                    write("Laser strömen aus deinem Mund, feuern auf deinen Gegner und vernichten ihn.\n" +
                                                        "Ein weiteres Tor nähert sich.\n" +
                                                        "Es sieht so aus, als wäre es ein Bisschen weit weg.");
                                                    prompt();
                                                    do
                                                    {
                                                        eingabeBekommen();
                                                    }
                                                    while (!valid());
                                                    if (eingabe == "SPRINGEN")
                                                    {
                                                        write("Du springst, aber leider zu früh. Bedauern füllt dein Gehirn, als du genau vor dem Tor landest. Alles vor deinen Augen wird schwarz.");
                                                    }
                                                    else
                                                    {
                                                        write("Du lässt das Tor näher kommen.\n" +
                                                            "Es sieht so aus, als ob du nun darüber springen kannst.");
                                                        prompt();
                                                        do
                                                        {
                                                            eingabeBekommen();
                                                        }
                                                        while (!valid());
                                                        if (eingabe != "SPRINGEN")
                                                        {
                                                            write("Du rennst in das Tor. Die Splitter graben sich tief in deine Schienbeine und du bereust, deinen Stall verlassen zu haben. Alles vor deinen Augen wird schwarz.");
                                                        }
                                                        else
                                                        {
                                                            write("Du springst darüber und fühlst dich schlau, da du gewartet hast.\n" +
                                                                "Ein großer, schimmernder Flaggenmast näher sich.");
                                                            prompt();
                                                            do
                                                            {
                                                                eingabeBekommen();
                                                            }
                                                            while (!valid());
                                                            write("Spielt keine Rolle.\n" +
                                                                "Dein Genick bricht, als es auf den Flaggenmast trifft. Es ist ok. Du bist nicht länger das Pony.\n" +
                                                                "Eine Explosion aus Konfetti verkündet deinen Erfolg.\n" +
                                                                "Du bekommst 9 Millionen Erfahrungspunkte und erreichts Level 1000\n" +
                                                                "Übergib nun deine Seele, um Grafik einzuschalten.");
                                                            while (true)
                                                                eingabeBekommen();
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            #endregion
                        }
                        else
                        {
                            write("Wie wäre es mit einer Text-Version des Klassikers \"The Stanley Parable\"?");
                            eingabeBekommen();
                            if (new string[] { "JA", "NEIN" }.Contains(eingabe))
                            {
                                eingabegueltig = true;
                            }
                            eingabegueltig = false;
                            if (eingabe == "JA")
                            {
                                #region Stanley Parable

                                Console.Clear();
                                write("Dies ist die Geschichte eines Mannes, der Stanley heißt.\n" +
                                    "Stanley arbeitete für eine Firma in einem großen Gebäude, wo er Mitarbeiter Nummer 427 war.\n" +
                                    "Die Arbeit von Mitarbeiter 427 war einfach: er saß an seinem Tisch in Raum 427 und drückte Tasten auf einer Tastatur.\n" +
                                    "Aufträge kamen durch einen Monitor auf seinem Tisch zu ihm und sagten ihm, welche Tasten er drücken musste, wie lange er sie drücken musste und in welcher Reihenfolge.\n" +
                                    "Das ist es, was Mitarbeiter 427 jeden Tag von jedem Monat, Jahr zu Jahr machte.\n" +
                                    "Und obwohl andere es womöglich seelen-zerstörend gefunden hätten, kostete Stanley jeden Moment aus, in dem Aufträge kamen, als sei er für diese Arbeit gemacht worden.\n" +
                                    "Und Stanley war glücklich.\n" +
                                    "Und dann, eines Tages, passierte etwas sehr merkwürdiges.\n" +
                                    "Etwas, das Stanley für immer verändern sollte;\n" +
                                    "etwas, was er niemals ganz vargessen würde.\n\n" +
                                    "Er saß für fast eine Stunde an seinem Schreibtisch, als er feststellte, dass nicht ein einziger Auftrag auf dem Monitor erschien, den er hätte erledigen sollen.\n" +
                                    "Niemand kam, um ihm Anweisungen zu geben, eine Versammlung einzuberufen oder auch nur 'Hallo' zu sagen. In all seinen Jahren bei der Firma ist das nie passiert, diese völlige Isolation.\n\n" +
                                    "Etwas war eindeutig falsch. Geschockt, wie festgefroren, konnte er sich für die längste Zeit nicht bewegen.\n" +
                                    "Aber als er wieder zu Sinnen kam, stand er von seinem Stuhl auf und ging aus seinem Büro heraus.\n" +
                                    "<fortfahren>");

                                eingabeBekommen();
                                Console.Clear();

                                spielen = true;
 
                                while (spielen)
                                {
                                    hasAdvanced = false;
                                    moeglichkeiten = new string[] { "Büro verlassen (Erzähler gehorchen)", "Tür schließen" };
                                    writeChoices();

                                    eingabegueltig = false;

                                    gueltigeEingabeBekommen();

                                    if (evaluate() == 2)
                                    {
                                        write("Aber Stanley konnte dem Druck nicht standhalten.\n" +
                                            "Was wäre, wenn er Entscheidungen treffen müsse? Was, wenn er für ein entscheidendes Ergebnis verantwortlich gemacht werden würde? Darauf wurde er nie vorbereitet! Nein, das könnte nur schlecht ausgehen.\n" +
                                            "\n" +
                                            "Das Beste, was ich tun kann, dachte Stanley sich, ist jetzt zu warten. Nichts wird mir weh tun. Nichts wird mich zerbrechen. Hier drin kann ich glücklich sein, für immer. I werde glücklich sein.\n" +
                                            "\n" +
                                            "Stanley wartete. Stunden vergingen. Dann Tage. Waren schon Jahre vergangen? Er war nicht mehr in der Lage, das zu beurteilen.\n" +
                                            "Aber die Sache, die er ganz sicher, abseits jeder Zweifel wusste, war, dass wenn er lang genug warten würde, die Antworten kommen würden.\n" +
                                            "Irgendwann, einges Tages, werden Sie kommen. Bald, sehr bald, wird das hier zu Ende gehen. Jemand wird mit ihm sprechen. Ihm wird gesagt werden, was er tun muss. Jetzt liegt dieser Moment schon etwas näher. Jetzt noch näher. Hier kommt er schon…\n");
                                        hasAdvanced = true;
                                    }
                                    else
                                    {
                                        writeRandom("All seine Mitarbeiter waren verschwunden. Was könnte das bedeuten? Stanley entschied sich, zum Besprechungsraum zu gehen, vielleicht hat er einfach nur eine Memo verpasst.",
                                            "Alle seine Mitarbeiter waren verschwunden. Was *hust*… oh, entschuldigung.",
                                            "Wie wundervoll. Stanley war ganz allein. Endlich. \"Das ist großartig\", dachte er sich. Das wollte ich schon die ganze Zeit. Ich habe bekommen, was ich wollte.",
                                            "Stanley entschied sich, in den Versammlungsraum zu gehen und nach seinen Mitarbeitern zu sehen. Er funktionierte alleine nie gut, und brauchte ständig Hilfe und Anleitungen, daher war der Gedanke totaler Einsamkeit für ihn schrecklich.",
                                            "Alle seine Mitarbeiter waren… warte, nein. Das ist nicht das richtige Büro, richtig? Ist das hier Stanleys Büro?",
                                            "\"Wie lang habe ich da gesessen?\" frage sich Stanley. Minuten? Tage? Jahrhunderte? Ist etwas entscheidendes passiert, w#hrend meine Sinne abgewandt waren? Er merkte sich, dass er von nun an vorsichtiger mit Zeit umging.",
                                            "Ein sanfter Wind wehte draußen und vielleicht begann es zu regnen, und wenn es das tat, dann hörte es kurz darauf wieder auf. Stanley hoffte, dass er eines Tages Wetter sehen könnte.",
                                            "Stanley dies, Stanley das, Stanley dies, Stanley das, Stanley dies, Stanley das, Stanley dies, Stanley das",
                                            "Jemand folgte Stanley. Da war er sich sicher. Wenn er jetzt hinter sich blicken würde, würde er die Person in Kürze erwischen. Es war nur eine Frage der Zeit.",
                                            "Schon jetzt war Stanleys Büro eine entfernte Erinnerung. Wie sah es aus. Da war vielleicht ein Computer… und ein Gemälde. War es ein Gemälde oder ein Foto? Er konnte sich nicht mehr erinnern.",
                                            "Der Versammlungsraum, ja, das ist, wo alle sein würden. Stanley musste nur zum Versammlungsraum gehen und von da an würde er niemals wieder alleine sein.",
                                            "\"Nur ein Schritt durch diese Tür\", dachte Stanley sich. \"Das ist alles, was ich brauche. Wenn ich es durch diese Tür schaffe, kann ich es durch sie alle schaffen.\"",
                                            "Das alleine war schon unangenehm und Stanley entschied sich, dass er, sobald er einen sicheren Ort finden würde, er diesen nie mehr verlassen würde.",
                                            "Stanley hatte das Büro noch nie so hell gesehen. War das ein Zeichen oder so? Er hoffte, dass es das war. Er hoffte so sehr darauf.",
                                            "\"Warte mal\" dachte Stanley sich. \"Bin ich mir sicher, dass die Aufträge aufgehört haben, zu erscheinen? Wie ist das möglich? Sie haben noch nie aufgehört. Ich habe mich sicherlich geirrt.\" [Stanley geht zu seinem Büro zurück] \"Nein. Nein, die Aufträge kommen immer noch nicht… für jetzt, zumindest\" [Stanley verlässt das Büro wieder]",
                                            "\"Ich kann es nicht erwarten, meinen Kollegen hiervon zu erzählen\" dachte Stanley sich. \"Wie witzig sie es finden werden. Oh, werden wir nicht alle lachen und lachen über das eine Mal, als ich dachte, jeder wäre verschwunden\".",
                                            "Stanley kannte den Aufbau des Büros wie seine Westentasche. Es war nur eine Frage der Zeit, bis er die anderen finden würde, wo auch immer sie seien. Nur eine Frage der Zeit…");

                                        while (!hasAdvanced)
                                        {
                                            moeglichkeiten = new string[] { "Zum Versammlungsraum gehen (Erzähler gehorchen)", "Umsehen", "Nichts tun" };
                                            writeChoices();
                                            gueltigeEingabeBekommen();
                                            if (evaluate() == 3)
                                                writeRandom("Stanley stand nur rum und tat gar nichts. Er scheint zu denken, dass ich nichts besseres zu tun habe, als rumzusitzen und jedes faszinierende kleine Detail seiner Unfähigkeit, etwas zu tun, zu beschreiben. Das ist der Grund, warum Stanley und ich uns so gut verstehen.",
                                                    "Stanley stand für eine lange zeit an einem Ort. Es ist Teil eines Spiels. Er guckt gerne, wie lange er überleben kann. Bis jetzt schlägt er sich ganz gut und wenn er nur da stehenbleibt, wo er ist, bin ich mir sicher, dass er dieses gute Momentum beibehalten wird. Lasst uns das Genie dabei beobachten.");
                                            else if (evaluate() == 2)
                                            {
                                                write("Egal, wie sehr sich Stanley umsag, von seinen Mitarbeitern war keine Spur zu finden\n" +
                                                    "[Du siehst dich um. Du siehst viele Türen, Schreibtische, auf denen Computer stehen und ein auffälliges Fenster]");
                                                moeglichkeiten = new string[] { "Aus dem Fenster klettern", "Sachen anfassen" };
                                                writeChoices();
                                                gueltigeEingabeBekommen();
                                                if (evaluate() == 2)
                                                    write("Stanley lief herum und fasste jedes kleinste Ding im Büro an, aber es machte keinen Unterschied und brachte die Geschichte nicht im Geringsten weiter.");

                                                else if (evaluate() == 1)
                                                {
                                                    hasAdvanced = true;
                                                    write("[Du kletters auf einen der Schreibtische und gehst aus dem Fenster. Alles, was du siehst ist weiß]\n" +
                                                        "Anfangs dachte Stanley, er hätte das Spiel kaputt gemacht, bis er diese Narration hörte und realisierte, dass es Teil des Spieldesigns war. " +
                                                        "Dann lobte er das Spiel für seine aufschluss- und geistreichen Kommentare zu der Natur von Videospiel-Struktur und seine Untersuchung " +
                                                        "von narrativen Tropen.\n" +
                                                        "Also, nun wo du hier bist, was denkst du? Ist das hier nichts ein spaßiger und einzigartiger Ort? Warum nehmen wir uns nicht einen " +
                                                        "Moment, um das alles zu verdauen. Ok, ich bin fertig. Was glaubst du, hast du schon genug von diesem Gag?");
                                                    moeglichkeiten = new string[] { "Ja", "Nein" };
                                                    writeChoices();
                                                    gueltigeEingabeBekommen();
                                                    if (evaluate() == 1)
                                                        write("Nun, ich weiß nicht, was ich dir das höflich sagen soll, aber du könntest dieses Programm einfach neustarten wann du willst. Zum " +
                                                            "Beispiel genau jetzt! Da hättest du es gerade machen können!\n" +
                                                            "Jetzt wäre auch ein geeigneter Zeitpunkt, um das Programm zu schließen.\n" +
                                                            "Jeder dieser Zeitpunkte und so viele viele mehr wären passend gewesen. Ich genieße, was ein interner Konflikt zu sein scheint, bei " +
                                                            "welchem du deinem eigenen Wunsch, das Spiel neuzustarten, nicht folgen kannst.\n" +
                                                            "Also, nur um es noch besser zu machen, werde ich es dir so miserabel wie möglich gestalten und wir sehen, wie lange du standhalten kannst.\n" +
                                                            "\n" +
                                                            "There once was a man named Stanley,\n" +
                                                            "Who people considered so manly\n" +
                                                            "But the truth must be told,\n" +
                                                            "He was not very old,\n" +
                                                            "And was quite particularly gangly\n" +
                                                            "\n" +
                                                            "What Stanley liked most was buttons." +
                                                            "He pushed them like some kind of glutton.\n" +
                                                            "He did it all day\n" +
                                                            "In a meaningful way,\n" +
                                                            "But his brain had long ceased to function.\n" +
                                                            "\n" +
                                                            "Which is why he is in this parable,\n" +
                                                            "And lives an existence quite terrible.\n" +
                                                            "And if you are not strong,\n" +
                                                            "And keep playing along,\n" +
                                                            "You too will become quite unbearable.\n" +
                                                            "You too will become quite unbearable.\n" +
                                                            "Yeah!" +
                                                            "<fortfahren>");
                                                    else
                                                        write("Ah, nun in diesem Fall werden wir das fortsetzen! Aber hier kommt die wahre Frage: was glaubst du, wäre passiert, wenn du gesagt " +
                                                            "hättest, dass du dem ein Ende setzen möchtest? Glaubst du, das es sonderlich anders wäre?\n" +
                                                            "Hätte ich diese gleiche Idee genommen und sie anders formuliert, damit sie zur anderen Antwort passt? Vielleicht hättest du gar " +
                                                            "nicht darüber nachgedacht, wenn ich es nicht erwähnt hätte!\n" +
                                                            "Oh, jetzt wo ich darüber nachdenke, wäre es das wert, das Spiel neuzustarten und wieder hierher ZURÜCK kommen, nur um die andere " +
                                                            "Option auszuprobierern? Offensichtlich beansprucht dieser Gag einige Zeit, was ist, wenn die andere Option noch länger ist? Wie " +
                                                            "viel wirst du insgesamt benötigen, nur um jeden Text gesehen zu haben?\n" +
                                                            "Oder - oh, das ist absurd - vielleicht hast du gerade die andere Option gespielt und jetzt bist du gekommen, um zu sehen, was " +
                                                            "passiert, wenn man diese nimmt! Also, was denkst du, welche ist die bessere Option?\n" +
                                                            "Stell dir vor, du hättest beim ersten Mal \"Ja\" gewählt qualvoll das wäre, nicht zu wissen, was passiert, wenn man die andere " +
                                                            "Option nimmt. In der Tat, du bist einer der Glücklichen.\n" +
                                                            "Wenn die andere Option allerdings schlect anzuhören ist, dann bist du das vielleicht nicht. Tatsächlich sage ich hiermit, dass " +
                                                            "niemand, der sich das durchliest zu den Glücklichen gehört.\n" +
                                                            "Nun, jetzt habe ich die andere Option so aufgebaut, dass ich aufhören werde, zu reden und dich deiner Entscheidung überlassen " +
                                                            "werde, ob du wieder herkommst, im Spiel fortfährst oder einfach nur für immer nur rumsitzen wirst. Tschüss\n" +
                                                            "<fortfahren>");
                                                    eingabeBekommen();
                                                }
                                            }
                                            //Actual Story
                                            else if (evaluate() == 1)
                                            {
                                                //Tür 430 Achievement?
                                                write("[Du gehst weiter]\n" +
                                                    "[Du stehst in einem kurzen Gang, der durch ein Fenster von Raum 417 getrennt ist. Du könntest beide Türen schließen oder einfach weitergehen]");
                                                moeglichkeiten = new string[] { "Türen schließen", "weitergehen" };
                                                writeChoices();
                                                gueltigeEingabeBekommen();
                                                if(evaluate() == 1)
                                                {
                                                    write("Oh, und äh, ich schätze, hier fühlt sich Stanley so, als wenn er genau jetzt hier sein sollte; in diesem kleinen Gang. Hier, ohne Ablekungen," +
                                                        " um Raum 417 zu studieren. Nicht, um ihn tatsächlich zu betreten, nein, nein, nein, nein, das wäre viel zu direkt. Stanley wollte wissen, wie er" +
                                                        " von außen ist - um ihn nicht nur mit seinen Augen zu sehen, sondern mit seinem Herzen. Er würde Raum 417 besser kennen, als es je ein Mann oder" +
                                                        " eine Frau ein Büro gekannt hat. Diese Leiter dort! Oh, und dieses kleine Bild eines Horizonts oder so! Es war eine nie endende Parade der Freude" +
                                                        " für Stanley.");
                                                    eingabeBekommen();
                                                    write("[Du öffnest die Türen wieder und verlässt den Gang]\n" +
                                                        "Ah, nein, anscheinend doch nicht.");
                                                }

                                                write("\nAls Stanley 2 offene Türen erreichte, ging er durch die Tür zu seiner Linken.");
                                                moeglichkeiten = new string[] { "Durch die linke Tür gehen (Erzähler gehorchen)", "Durch die linke Tür gehen (Erzähler nicht gehorchen)" };
                                                writeChoices();
                                                gueltigeEingabeBekommen();
                                                if(evaluate() == 1)
                                                {
                                                    //Linke Tür
                                                    write("[Du läufst zum Versammlungsraum]\n" +
                                                        "Doch auch hier ist keine einzige Person. Ungläubig läuft Stanley zum Büro seines Chefs, in der Hoffnung, da etwas zu finden.\n" +
                                                        "[Du läufst an einer Besenkammer vorbei]");
                                                    //Besenkammer
                                                    write("[Du erreichst ein Treppenhaus]\n" +
                                                        "Als Stanley ein Treppenhaus erreicht, ging er die Treppe zum Büro seines Chefs hoch.");
                                                    moeglichkeiten = new string[] { "Treppe hoch gehen (Erzähler gehorchen)", "Treppe runter gehen (Erzähler nicht gehorchen)" };
                                                    writeChoices();
                                                    gueltigeEingabeBekommen();
                                                    if(evaluate() == 1)
                                                    {
                                                        //Treppe hoch
                                                        writeRandom("");
                                                    }
                                                    else
                                                    {
                                                        //Treppe runter

                                                    }
                                                }
                                                else
                                                {
                                                    //Rechte Tür
                                                }
                                            }
                                        }
                                    }


                                    write("[NEUSTART]\n");
                                }
                                #endregion
                            }
                        }
                    }
                }

            }

            void writeInColor(string s, ConsoleColor consoleColor, object[] vs)
            {
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(s, vs);
                Console.ForegroundColor = ConsoleColor.White;
            }

            void writeRandom(params string[] strs)
            {
                write(strs[random.Next(strs.Length)]);
            }

            void write(object o, params object[] vs)
            {
                string s = o.ToString(); 
                string newStr = "";

                for (int i = 0, j = 0; i < s.Length; i++, j++)
                {
                    if (s[i] == '\n' || s[i] == '\r')
                    {
                        newStr += s.Substring(0, i);
                        s = s.Substring(i, s.Length - i);
                        i = 0;
                    }
                    if (i >= Console.WindowWidth)
                    {
                        try
                        {
                            while (s[i] != ' ' && s[i - 1] != '-')
                            {
                                i--;
                            }
                        }
                        catch
                        {
                            i = Console.WindowWidth;
                        }

                        int temp = 0;
                        if (s[i] == ' ')
                            temp = 1;

                        newStr += s.Substring(0, i) + "\n";
                        i += temp;
                        s = s.Substring(i, s.Length - i);
                        i = 0;
                    }
                    if (i == s.Length - 1)
                    {
                        newStr += s;
                    }
                }
                if (newStr == "")
                    newStr = s;
                s = newStr;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.CursorVisible = false;

                for (int i = 0; i < vs.Length; i++)
                {
                    s = s.Replace("{" + i + "}", vs[i].ToString());
                }

                char[] arr = s.ToArray();

                foreach (char c in arr)
                {
                    Console.Write(c);
                    System.Threading.Thread.Sleep(characterWait + random.Next(-randomWait, randomWait + 1));
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.White;
                Console.CursorVisible = true;
            }

            void writePrompt(string s, params object[] vs)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(s, vs);
                Console.ForegroundColor = ConsoleColor.White;
            }

            void writeChoices(string[] array = null)
            {
                if (array == null)
                    array = moeglichkeiten;
                for (int i = 0; i < array.Length; i++)
                {
                    write((i + 1) + ": " + array[i]);
                }
            }

            int evaluate(string[] arr = null, string s = null)
            {
                if (arr == null)
                    arr = moeglichkeiten;
                if (s == null)
                    s = eingabe;

                s = s.Trim();
                int i;
                if (!Int32.TryParse(s, out i))
                    i = Array.FindIndex(arr, t => t.Equals(s, StringComparison.InvariantCultureIgnoreCase)) + 1;

                return i;
            }

            void gueltigeEingabeBekommen()
            {
                eingabegueltig = false;
                while (!eingabegueltig)
                {

                    eingabeBekommen();
                    if (evaluate() != 0)
                        eingabegueltig = true;
                }
            }

            void eingabeBekommen()
            {
                eingabe = Console.ReadLine().ToUpper().Trim();
            }
        }
    }
}
