# Dashboard

Dashboard-Navigation für Xbox und Windows. Das Projekt ist als überschaubares Lernbeispiel für C#, UWP und die Bereitstellung auf einer Xbox One gedacht.

## Tutorial

Die vollständige Schrittfolge mit Hinweisen zu Visual Studio, Developer Mode und Gamepad-Eingabe steht im [XboxDev-Tutorial](https://xboxdev.com/tutorials/xbox-uwp-example-dashboard/).

## Voraussetzungen

- Windows mit Visual Studio und installierter **Universal Windows Platform development**-Workload
- Eine Xbox One im Developer Mode oder der UWP-Simulator
- Visual Studio-Konfiguration **Debug**, Plattform **x64**

## Projekt öffnen und starten

1. Repository klonen oder als ZIP laden: [example-dashboard](https://github.com/XboxDevCom/example-dashboard).
2. **Dashboard.sln** in Visual Studio öffnen.
3. **x64** als Plattform auswählen. Für lokale Tests genügt der Simulator; für die Konsole **Remote Machine** wählen, die Xbox-IP eintragen und den Pairing-PIN aus dem Developer Portal bestätigen.
4. Mit **Erstellen** kompilieren und mit **Bereitstellen** auf Simulator oder Konsole starten.

## Projektaufbau

Der zentrale Quellcode liegt im Ordner **Dashboard/**. Öffne zuerst die Startseite und verfolge anschließend die zugehörige C#-Datei. So lässt sich nachvollziehen, wie Oberfläche, Eingabe und Zustand zusammenspielen.

### Gute erste Änderungen

Zeigt eine Dashboard-Oberfläche mit Navigation, Bereichen und TV-tauglichem Layout. Ändere danach Farben, Texte oder ein Asset und prüfe die Bereitstellung erneut. Bei Xbox-Oberflächen sind Fokusführung und ein lesbares Layout aus größerer Entfernung wichtig.

## Hinweise

Die Beispiele stammen aus der UWP- und Xbox-One-Entwicklungsphase. Für neue Projekte sollte geprüft werden, ob Windows App SDK oder Xbox GDK besser passt.

## Lizenz

Die Lizenzbedingungen stehen in der Datei [LICENSE](LICENSE).
