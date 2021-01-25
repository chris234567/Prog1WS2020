<html><head><meta http-equiv="Content-Type" content="text/html; charset=utf-8"/><title>Programmieren 1 Klausur</title><style>
/* webkit printing magic: print all background colors */
html {
	-webkit-print-color-adjust: exact;
}
* {
	box-sizing: border-box;
	-webkit-print-color-adjust: exact;
}

html,
body {
	margin: 0;
	padding: 0;
}
@media only screen {
	body {
		margin: 2em auto;
		max-width: 900px;
		color: rgb(55, 53, 47);
	}
}

body {
	line-height: 1.5;
	white-space: pre-wrap;
}

a,
a.visited {
	color: inherit;
	text-decoration: underline;
}

.pdf-relative-link-path {
	font-size: 80%;
	color: #444;
}

h1,
h2,
h3 {
	letter-spacing: -0.01em;
	line-height: 1.2;
	font-weight: 600;
	margin-bottom: 0;
}

.page-title {
	font-size: 2.5rem;
	font-weight: 700;
	margin-top: 0;
	margin-bottom: 0.75em;
}

h1 {
	font-size: 1.875rem;
	margin-top: 1.875rem;
}

h2 {
	font-size: 1.5rem;
	margin-top: 1.5rem;
}

h3 {
	font-size: 1.25rem;
	margin-top: 1.25rem;
}

.source {
	border: 1px solid #ddd;
	border-radius: 3px;
	padding: 1.5em;
	word-break: break-all;
}

.callout {
	border-radius: 3px;
	padding: 1rem;
}

figure {
	margin: 1.25em 0;
	page-break-inside: avoid;
}

figcaption {
	opacity: 0.5;
	font-size: 85%;
	margin-top: 0.5em;
}

mark {
	background-color: transparent;
}

.indented {
	padding-left: 1.5em;
}

hr {
	background: transparent;
	display: block;
	width: 100%;
	height: 1px;
	visibility: visible;
	border: none;
	border-bottom: 1px solid rgba(55, 53, 47, 0.09);
}

img {
	max-width: 100%;
}

@media only print {
	img {
		max-height: 100vh;
		object-fit: contain;
	}
}

@page {
	margin: 1in;
}

.collection-content {
	font-size: 0.875rem;
}

.column-list {
	display: flex;
	justify-content: space-between;
}

.column {
	padding: 0 1em;
}

.column:first-child {
	padding-left: 0;
}

.column:last-child {
	padding-right: 0;
}

.table_of_contents-item {
	display: block;
	font-size: 0.875rem;
	line-height: 1.3;
	padding: 0.125rem;
}

.table_of_contents-indent-1 {
	margin-left: 1.5rem;
}

.table_of_contents-indent-2 {
	margin-left: 3rem;
}

.table_of_contents-indent-3 {
	margin-left: 4.5rem;
}

.table_of_contents-link {
	text-decoration: none;
	opacity: 0.7;
	border-bottom: 1px solid rgba(55, 53, 47, 0.18);
}

table,
th,
td {
	border: 1px solid rgba(55, 53, 47, 0.09);
	border-collapse: collapse;
}

table {
	border-left: none;
	border-right: none;
}

th,
td {
	font-weight: normal;
	padding: 0.25em 0.5em;
	line-height: 1.5;
	min-height: 1.5em;
	text-align: left;
}

th {
	color: rgba(55, 53, 47, 0.6);
}

ol,
ul {
	margin: 0;
	margin-block-start: 0.6em;
	margin-block-end: 0.6em;
}

li > ol:first-child,
li > ul:first-child {
	margin-block-start: 0.6em;
}

ul > li {
	list-style: disc;
}

ul.to-do-list {
	text-indent: -1.7em;
}

ul.to-do-list > li {
	list-style: none;
}

.to-do-children-checked {
	text-decoration: line-through;
	opacity: 0.375;
}

ul.toggle > li {
	list-style: none;
}

ul {
	padding-inline-start: 1.7em;
}

ul > li {
	padding-left: 0.1em;
}

ol {
	padding-inline-start: 1.6em;
}

ol > li {
	padding-left: 0.2em;
}

.mono ol {
	padding-inline-start: 2em;
}

.mono ol > li {
	text-indent: -0.4em;
}

.toggle {
	padding-inline-start: 0em;
	list-style-type: none;
}

/* Indent toggle children */
.toggle > li > details {
	padding-left: 1.7em;
}

.toggle > li > details > summary {
	margin-left: -1.1em;
}

.selected-value {
	display: inline-block;
	padding: 0 0.5em;
	background: rgba(206, 205, 202, 0.5);
	border-radius: 3px;
	margin-right: 0.5em;
	margin-top: 0.3em;
	margin-bottom: 0.3em;
	white-space: nowrap;
}

.collection-title {
	display: inline-block;
	margin-right: 1em;
}

time {
	opacity: 0.5;
}

.icon {
	display: inline-block;
	max-width: 1.2em;
	max-height: 1.2em;
	text-decoration: none;
	vertical-align: text-bottom;
	margin-right: 0.5em;
}

img.icon {
	border-radius: 3px;
}

.user-icon {
	width: 1.5em;
	height: 1.5em;
	border-radius: 100%;
	margin-right: 0.5rem;
}

.user-icon-inner {
	font-size: 0.8em;
}

.text-icon {
	border: 1px solid #000;
	text-align: center;
}

.page-cover-image {
	display: block;
	object-fit: cover;
	width: 100%;
	height: 30vh;
}

.page-header-icon {
	font-size: 3rem;
	margin-bottom: 1rem;
}

.page-header-icon-with-cover {
	margin-top: -0.72em;
	margin-left: 0.07em;
}

.page-header-icon img {
	border-radius: 3px;
}

.link-to-page {
	margin: 1em 0;
	padding: 0;
	border: none;
	font-weight: 500;
}

p > .user {
	opacity: 0.5;
}

td > .user,
td > time {
	white-space: nowrap;
}

input[type="checkbox"] {
	transform: scale(1.5);
	margin-right: 0.6em;
	vertical-align: middle;
}

p {
	margin-top: 0.5em;
	margin-bottom: 0.5em;
}

.image {
	border: none;
	margin: 1.5em 0;
	padding: 0;
	border-radius: 0;
	text-align: center;
}

.code,
code {
	background: rgba(135, 131, 120, 0.15);
	border-radius: 3px;
	padding: 0.2em 0.4em;
	border-radius: 3px;
	font-size: 85%;
	tab-size: 2;
}

code {
	color: #eb5757;
}

.code {
	padding: 1.5em 1em;
}

.code-wrap {
	white-space: pre-wrap;
	word-break: break-all;
}

.code > code {
	background: none;
	padding: 0;
	font-size: 100%;
	color: inherit;
}

blockquote {
	font-size: 1.25em;
	margin: 1em 0;
	padding-left: 1em;
	border-left: 3px solid rgb(55, 53, 47);
}

.bookmark {
	text-decoration: none;
	max-height: 8em;
	padding: 0;
	display: flex;
	width: 100%;
	align-items: stretch;
}

.bookmark-title {
	font-size: 0.85em;
	overflow: hidden;
	text-overflow: ellipsis;
	height: 1.75em;
	white-space: nowrap;
}

.bookmark-text {
	display: flex;
	flex-direction: column;
}

.bookmark-info {
	flex: 4 1 180px;
	padding: 12px 14px 14px;
	display: flex;
	flex-direction: column;
	justify-content: space-between;
}

.bookmark-image {
	width: 33%;
	flex: 1 1 180px;
	display: block;
	position: relative;
	object-fit: cover;
	border-radius: 1px;
}

.bookmark-description {
	color: rgba(55, 53, 47, 0.6);
	font-size: 0.75em;
	overflow: hidden;
	max-height: 4.5em;
	word-break: break-word;
}

.bookmark-href {
	font-size: 0.75em;
	margin-top: 0.25em;
}

.sans { font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Helvetica, "Apple Color Emoji", Arial, sans-serif, "Segoe UI Emoji", "Segoe UI Symbol"; }
.code { font-family: "SFMono-Regular", Consolas, "Liberation Mono", Menlo, Courier, monospace; }
.serif { font-family: Lyon-Text, Georgia, YuMincho, "Yu Mincho", "Hiragino Mincho ProN", "Hiragino Mincho Pro", "Songti TC", "Songti SC", "SimSun", "Nanum Myeongjo", NanumMyeongjo, Batang, serif; }
.mono { font-family: iawriter-mono, Nitti, Menlo, Courier, monospace; }
.pdf .sans { font-family: Inter, -apple-system, BlinkMacSystemFont, "Segoe UI", Helvetica, "Apple Color Emoji", Arial, sans-serif, "Segoe UI Emoji", "Segoe UI Symbol", 'Twemoji', 'Noto Color Emoji', 'Noto Sans CJK SC', 'Noto Sans CJK KR'; }

.pdf .code { font-family: Source Code Pro, "SFMono-Regular", Consolas, "Liberation Mono", Menlo, Courier, monospace, 'Twemoji', 'Noto Color Emoji', 'Noto Sans Mono CJK SC', 'Noto Sans Mono CJK KR'; }

.pdf .serif { font-family: PT Serif, Lyon-Text, Georgia, YuMincho, "Yu Mincho", "Hiragino Mincho ProN", "Hiragino Mincho Pro", "Songti TC", "Songti SC", "SimSun", "Nanum Myeongjo", NanumMyeongjo, Batang, serif, 'Twemoji', 'Noto Color Emoji', 'Noto Sans CJK SC', 'Noto Sans CJK KR'; }

.pdf .mono { font-family: PT Mono, iawriter-mono, Nitti, Menlo, Courier, monospace, 'Twemoji', 'Noto Color Emoji', 'Noto Sans Mono CJK SC', 'Noto Sans Mono CJK KR'; }

.highlight-default {
}
.highlight-gray {
	color: rgb(155,154,151);
}
.highlight-brown {
	color: rgb(100,71,58);
}
.highlight-orange {
	color: rgb(217,115,13);
}
.highlight-yellow {
	color: rgb(223,171,1);
}
.highlight-teal {
	color: rgb(15,123,108);
}
.highlight-blue {
	color: rgb(11,110,153);
}
.highlight-purple {
	color: rgb(105,64,165);
}
.highlight-pink {
	color: rgb(173,26,114);
}
.highlight-red {
	color: rgb(224,62,62);
}
.highlight-gray_background {
	background: rgb(235,236,237);
}
.highlight-brown_background {
	background: rgb(233,229,227);
}
.highlight-orange_background {
	background: rgb(250,235,221);
}
.highlight-yellow_background {
	background: rgb(251,243,219);
}
.highlight-teal_background {
	background: rgb(221,237,234);
}
.highlight-blue_background {
	background: rgb(221,235,241);
}
.highlight-purple_background {
	background: rgb(234,228,242);
}
.highlight-pink_background {
	background: rgb(244,223,235);
}
.highlight-red_background {
	background: rgb(251,228,228);
}
.block-color-default {
	color: inherit;
	fill: inherit;
}
.block-color-gray {
	color: rgba(55, 53, 47, 0.6);
	fill: rgba(55, 53, 47, 0.6);
}
.block-color-brown {
	color: rgb(100,71,58);
	fill: rgb(100,71,58);
}
.block-color-orange {
	color: rgb(217,115,13);
	fill: rgb(217,115,13);
}
.block-color-yellow {
	color: rgb(223,171,1);
	fill: rgb(223,171,1);
}
.block-color-teal {
	color: rgb(15,123,108);
	fill: rgb(15,123,108);
}
.block-color-blue {
	color: rgb(11,110,153);
	fill: rgb(11,110,153);
}
.block-color-purple {
	color: rgb(105,64,165);
	fill: rgb(105,64,165);
}
.block-color-pink {
	color: rgb(173,26,114);
	fill: rgb(173,26,114);
}
.block-color-red {
	color: rgb(224,62,62);
	fill: rgb(224,62,62);
}
.block-color-gray_background {
	background: rgb(235,236,237);
}
.block-color-brown_background {
	background: rgb(233,229,227);
}
.block-color-orange_background {
	background: rgb(250,235,221);
}
.block-color-yellow_background {
	background: rgb(251,243,219);
}
.block-color-teal_background {
	background: rgb(221,237,234);
}
.block-color-blue_background {
	background: rgb(221,235,241);
}
.block-color-purple_background {
	background: rgb(234,228,242);
}
.block-color-pink_background {
	background: rgb(244,223,235);
}
.block-color-red_background {
	background: rgb(251,228,228);
}
.select-value-color-default { background-color: rgba(206,205,202,0.5); }
.select-value-color-gray { background-color: rgba(155,154,151, 0.4); }
.select-value-color-brown { background-color: rgba(140,46,0,0.2); }
.select-value-color-orange { background-color: rgba(245,93,0,0.2); }
.select-value-color-yellow { background-color: rgba(233,168,0,0.2); }
.select-value-color-green { background-color: rgba(0,135,107,0.2); }
.select-value-color-blue { background-color: rgba(0,120,223,0.2); }
.select-value-color-purple { background-color: rgba(103,36,222,0.2); }
.select-value-color-pink { background-color: rgba(221,0,129,0.2); }
.select-value-color-red { background-color: rgba(255,0,26,0.2); }

.checkbox {
	display: inline-flex;
	vertical-align: text-bottom;
	width: 16;
	height: 16;
	background-size: 16px;
	margin-left: 2px;
	margin-right: 5px;
}

.checkbox-on {
	background-image: url("data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%2216%22%20height%3D%2216%22%20viewBox%3D%220%200%2016%2016%22%20fill%3D%22none%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%3E%0A%3Crect%20width%3D%2216%22%20height%3D%2216%22%20fill%3D%22%2358A9D7%22%2F%3E%0A%3Cpath%20d%3D%22M6.71429%2012.2852L14%204.9995L12.7143%203.71436L6.71429%209.71378L3.28571%206.2831L2%207.57092L6.71429%2012.2852Z%22%20fill%3D%22white%22%2F%3E%0A%3C%2Fsvg%3E");
}

.checkbox-off {
	background-image: url("data:image/svg+xml;charset=UTF-8,%3Csvg%20width%3D%2216%22%20height%3D%2216%22%20viewBox%3D%220%200%2016%2016%22%20fill%3D%22none%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%3E%0A%3Crect%20x%3D%220.75%22%20y%3D%220.75%22%20width%3D%2214.5%22%20height%3D%2214.5%22%20fill%3D%22white%22%20stroke%3D%22%2336352F%22%20stroke-width%3D%221.5%22%2F%3E%0A%3C%2Fsvg%3E");
}
	
</style></head><body><article id="240b1c75-4fe1-4af9-bcc9-94de509d8a4b" class="page sans"><header><div class="page-header-icon undefined"><span class="icon">🖥️</span></div><h1 class="page-title">Programmieren 1 Klausur</h1></header><div class="page-body"><h1 id="862ae1c0-0551-41a5-adf6-68a60559660e" class="">Transkript der Aufgabenstellung</h1><hr id="5dd09f24-c48e-4137-8cd7-b647dc21ac84"/><p id="4741d30b-d523-430b-be80-f630d7e3202c" class="">Da ich das Urheberrecht für die Klausur leider nicht besitze und die Erlaubnis das PDF direkt hier zu teilen nicht bekommen habe, folgt nun ein Transkript der Aufgabenstellungen, um den Code nachzuvollziehen.</p><h1 id="f0ec7351-aa41-4c2f-85e6-4c03bcffc372" class="">Aufgabe 1 </h1><blockquote id="fcb066e5-a8cc-44a3-b4bf-b76a28b35167" class="">15 Punkte</blockquote><hr id="29dfaf85-33b0-4740-a0ff-1c9a00c0567a"/><p id="4c1765c4-756f-487c-a971-6c53f0f9cb0f" class="">Schreiben Sie eine Funktion, die errechnet, nach wie vielen Jahren ein bestimmter Geldbetrag angespart ist, wenn jährlich ein bestimmter Betrag, zu einem bestimmten Zinssatz verzinst,
einzahlt wird.</p><p id="53ab5d14-2b0f-4ba0-8d0a-51bca6d8e91e" class="">Funktions-Parameter: </p><ul id="5fd7886c-5388-4c11-97e0-4479e08a682e" class="bulleted-list"><li>Wunschbetrag</li></ul><ul id="8bc167c4-d42f-4807-9fcd-a98450c9aa6d" class="bulleted-list"><li>jährlichen Sparbetrag</li></ul><ul id="e3dab728-d436-4088-947a-75e12b9e98b3" class="bulleted-list"><li>jährlichen Zinssatz</li></ul><p id="7cc7e8dc-a6d2-4531-8de8-ba4223ab0165" class="">Es werden nun wiederholt die Zinsen zum jeweils vorhandenen Kapital addiert plus den Sparbetrag. Dabei werden die Jahre gezählt und der tatsächlich gezahlte Betrag aufsummiert, wiederholt bis zum Wunschbetrag.</p><p id="f04e7ece-c1d5-4d73-9bed-e613f550b467" class="">Das jährliche Kapital sowie der bisher eingezahlte Betrag soll ausgegeben werden.
Zum Schluss soll die Anzahl der Jahre mit dem insgesamt eingezahlten Betrag ausgegeben werden.</p><h1 id="19955345-dffc-4491-a873-9d9c03301d29" class="">Aufgabe 2</h1><blockquote id="393234ff-cb71-46ee-9510-d6c7eb66cc31" class="">15 Punkte</blockquote><hr id="3ca79f7c-2482-46ce-bc53-0458e5572a5e"/><h3 id="ac775d47-d925-493a-85f9-b50872a869de" class="">a)</h3><p id="f22d3629-f540-4370-84b6-1307357dfb59" class="">Programmieren Sie eine Funktion, die ein eindimensionales Integer Array beliebiger Länge mit Zufallszahlen (0 bis 9) füllt und das Array zurück gibt.</p><p id="814c7215-f1b0-4a36-82ce-4358ee0c99b8" class="">Klasse Random ist erlaubt</p><h3 id="c347cf84-9f95-4c3f-a0be-ebf467dbcdc4" class="">b)</h3><p id="36c096be-150b-4a9e-ac9c-7eb1454dddd5" class="">Fragen Sie über die Konsole nach der Matrikelnummer und programmieren Sie eine weitere Funktion, die die Ziffern entsprechend in ein eindimensionales Integer Array speichert und dieses dann mit einem Array aus a) zu einem einzigen Array zusammenführt. Dabei sollen erst alle geraden (mit 0) und dann alle ungeraden Ziffern im neuen Array stehen.</p><p id="2e3f871b-8c57-4f5c-a809-bd99ecec61ff" class="">(Es muss nicht sortiert werden und die Eingabe der Matrikelnummer muss nicht auf Richtigkeit geprüft werden)</p><p id="7f3d295b-dd59-4771-91fb-df063ecab494" class="">Methoden der Klasse Array, außer Property Length, sind nicht erlaubt .</p><h3 id="3c20ee54-5c98-4b7f-967c-347e5bf3a504" class="">c)</h3><p id="e388d12e-0c2a-49a8-a3ae-25451c58ce37" class="">Schreiben sie eine Funktion, die das Array auf der Konsole ausgibt.</p><h1 id="5e657150-19f5-4323-b101-67fcc75aceea" class="">Aufgabe 3</h1><blockquote id="f4fb491a-7595-477d-b328-bf2670bcc563" class="">30 Punkte</blockquote><hr id="079fea10-e41b-4a51-9a6b-11becd05d98f"/><ul id="1b1530fd-65f8-4f6a-a791-f4ce13269ba3" class="bulleted-list"><li>Achten Sie bei der Realisierung auf die korrekte Verwendung von static sowie
auf die richtige Positionierung des Aufzähltypen.</li></ul><ul id="a73e0542-d686-4e6f-b28b-4e2522d68683" class="bulleted-list"><li>Es sind keine zusätzlichen Bibliotheksfunktionen erlaubt (werden auch nicht
benötigt).</li></ul><ul id="d7197dfa-7935-4e0f-8b2c-f9cbada1237e" class="bulleted-list"><li>Halten Sie sich an die Namenskonventionen für die Gross-/Kleinschreibung von
Klassen, Properties, Methoden und (Member-)Variablen.</li></ul><p id="ef904a72-4bc0-4603-b201-b306607076ff" class="">Definieren Sie folgende Typen und Methoden für die Verwaltung eines PKW-Fuhrparks</p><ul id="93287909-9a5d-41cc-a156-131081c771fc" class="bulleted-list"><li>Aufzähltyp FahrzeugTyp mit den Werten Kompakt, SUV, Kombi</li></ul><ul id="f582ed0e-3622-4f5d-bddf-4f0df87fc646" class="bulleted-list"><li>Klasse Fahrzeug mit folgenden (privaten) Eigenschaften und Methoden:<ul id="2d1a1ecb-e468-4028-a6bd-f1f0c1a505a6" class="bulleted-list"><li>Nr: eindeutige Nummer (automatisch im Konstruktor zu vergeben)</li></ul><ul id="fa1c7bf1-2772-41a8-a81a-6903219f2b58" class="bulleted-list"><li>Modell: Modell-Bezeichnung, z.B. &quot;BMW X5&quot;</li></ul><ul id="e79c9b86-5fc2-41e5-adcf-6895e89515d3" class="bulleted-list"><li>Verbrauch: Verbrauch in l/100km (Gleitkomma-Zahl)</li></ul><ul id="38517829-54f5-4568-a8f3-931b8c6ad3e0" class="bulleted-list"><li>Typ: Typ des Fahrzeugs (Aufzähltyp von oben)</li></ul><ul id="f6ac8e06-208f-43b8-a0f0-a5163215bbd7" class="bulleted-list"><li>Öffentlicher Konstruktor für die Erstellung eines neuen Fahrzeug-Objekts:<ul id="48feb0e2-95fe-47f6-8d61-08390cd52fe2" class="bulleted-list"><li>Der Konstruktor erhält Parameter für Modell, Verbrauch und Typ.</li></ul><ul id="1e39538b-f278-4d4c-8d74-19abdd178610" class="bulleted-list"><li>Der Parameter für den Typ ist optional. Falls nicht angegeben, wird er
auf Kompakt gesetzt.</li></ul><ul id="d74e7619-bfb4-4d82-8d04-e1d661cdef2f" class="bulleted-list"><li>Stellen Sie sicher, dass die Modell-Bezeichnung mindestens 3 Zeichen
lang ist und der Verbrauch 15l nicht überschreitet. Anderenfalls lösen
Sie eine ArgumentException aus.</li></ul><ul id="730c707d-e600-48c2-8d54-242a193f0578" class="bulleted-list"><li>Die Nr soll im Konstruktor automatisch fortlaufend vergeben werden,
d.h. jedes Fahrzeug erhält eine eigene eindeutige Nummer.</li></ul></li></ul><ul id="c81fa38f-66e0-4b0a-8620-2ad2de464fc3" class="bulleted-list"><li>Öffentliches Read-Write-Property für das Modell. Auch hier muss sichergestellt werden, dass die Bezeichnung mindestens 5 Zeichen lang ist. Andernfalls ist eine ArgumentException auszulösen.</li></ul><ul id="d98c903e-27e8-4d48-bbfd-e3b064f5b986" class="bulleted-list"><li>Öffentliches Read-Only-Property für den Verbrauch.</li></ul><ul id="ddec603d-26b8-4597-aedb-ffcb758692d4" class="bulleted-list"><li>Öffentliches Read-Only-Property für den Typ.</li></ul><ul id="92be50f4-4213-40e1-9740-a1c345fdb62a" class="bulleted-list"><li>Methode ToString(), welche eine String-Repräsentation der Form &quot;1. Kompakt VW Golf 6,3l/100km)&quot; erzeugt (Beispiel für die Ausgabe des ersten Fahrzeugs in der Main).</li></ul></li></ul><ul id="fea5c82f-8867-4486-afac-2d407f0b6a9e" class="bulleted-list"><li>Klasse Fuhrpark, die aus einer Menge (privates Array) von Fahrzeugen besteht, mit:<ul id="cd14c07b-61bb-4f0f-a1d1-17e26ee40053" class="bulleted-list"><li>Konstruktor, der ein Array oder eine beliebige Anzahl von Fahrzeugen als
Parameter übernimmt.</li></ul><ul id="5989247b-792d-43fd-90f8-2864a130cb52" class="bulleted-list"><li>Methode Sparsamstes, welche das Fahrzeug-Objekt ermittelt und zurückgibt, das den geringsten Verbrauch aufweist. Sollte es mehrere mit gleichem
Verbrauchswert geben, so ist das erste zurückzugeben.
Tipp: Merken Sie sich bei der Suche in einer Variablen immer das Fahrzeug
mit dem geringsten Verbrauch.</li></ul></li></ul><p id="1c8b40a3-06d2-4d61-8552-eab05c701988" class="">
</p><h1 id="3ea48a42-5f23-4d0a-8301-4664178a95b2" class="">Aufgabe 4</h1><blockquote id="f2a01908-3bb7-44a3-b7fa-ceff746f8c24" class="">20 Punkte</blockquote><hr id="55140356-30f7-41b7-a750-887b0da6e18e"/><p id="15268a78-04c1-4271-8ab1-ba900a60b887" class="">Es soll die vorgegeben Main ergänzt werden.</p><p id="1c5add0f-19dd-46fb-a9af-a0ac5b1d2ae3" class="">Erstellen sie ein Enum Lighttype für die Typen der Quadrate.</p><ul id="88166bf1-f705-4f36-a3ec-6afe41448de6" class="bulleted-list"><li>Panel: Lichtfläche</li></ul><ul id="dda65fed-6a2d-4968-a83e-9f50d2dbb03d" class="bulleted-list"><li>Sparkle: Funkeln</li></ul><ul id="4b2dc2c1-a057-486d-a1a6-540046744429" class="bulleted-list"><li>LED: LED Punkte</li></ul><ul id="98e520c6-d5f3-4bad-8bc0-9d6bc1ffac3f" class="bulleted-list"><li>Spot: Scheinwerfer</li></ul><ul id="38be43d5-5420-4b1a-8cab-bb5f39d65a2e" class="bulleted-list"><li>FogMachine: Nebelmaschine</li></ul><h3 id="50d25cd2-1268-4436-abb2-93df71da194d" class="">a)</h3><p id="c9ad7887-1a98-40d0-9f4e-ee8b83681b1a" class="">Implementieren Sie eine Methode FractionFog, die den Anteil der Quadrate mit Nebelmaschinen zurückgibt. Sind z.B. 2 von 10 Quadraten mit einer Nebelmaschine belegt, wird 0,2 zurückgegeben.</p><h3 id="b262e922-9180-4ede-a3bb-00261bf14db3" class="">b)</h3><p id="c81cb0cd-9cf3-4a9b-8a8f-92c864f24b9f" class="">Implementieren Sie eine Methode PrintField. Sie soll für ein Quadrat aus dem
Übersichtsplan die passenden zwei Zeichen ausgeben. Um welche es sich handelt,
sehen Sie im Kommentar des Codes. Die Methode bekommt den Übersichtsplan
sowie Koordinaten übergeben. Die Koordinaten dürfen jedoch ausserhalb des
Plans liegen. In diesen Fällen müssen sie umgerechnet werden. So kann der
Übersichtsplan als quasi endlos betrachtet werden. Ist die Breite 10, gibt es
real die Index-Werte 0 bis 9. Die Angabe 10 wird dann zu 0 umgerechnet, 11
zu 1, usw. Das soll auch umgekehrt funktionieren, beispielweise wird -1 zu 9
umgerechnet.</p><h3 id="dce1917a-cc54-43b5-9722-21bcab1e3924" class="">c)</h3><p id="80a14992-7ba8-4d4d-9097-caa247563269" class="">Implementieren Sie eine Methode Print. Diese soll den Übersichtsplan auf der
Console ausgeben. Sie können dazu die Methode PrintField verwenden.</p><h1 id="4887c224-2b20-43dd-8d8b-8bb8d0ad6e31" class="">Aufgabe 5</h1><blockquote id="fdd481cb-0364-40c3-9aba-45c1aceec6a5" class="">20 Punkte</blockquote><p id="8f17ce24-195f-48d0-9a6a-8b8fac37bc04" class="">Lesen Sie die .txt Datei und suchen Sie nach zusammenhängenden Sturmperioden. Eine
Sturmperiode ist folgendermassen definiert:</p><ul id="05b925d3-cc99-4d8e-978b-5f072dd17a3b" class="bulleted-list"><li>mindestens drei zusammenhängend aufeinanderfolgende Tage (Datensätze) mit</li></ul><ul id="c152307a-a039-4187-9361-a0cdd2c83aa6" class="bulleted-list"><li>einer Windgeschwindigkeit von mind. 20 m/s (Spalte WINDSPITZE_MAXIMUM)</li></ul><p id="7726bc58-675f-48db-9d0a-1c27f7a2d692" class="">Geben Sie das Ergebnis in folgender Form aus:<div class="indented"><p id="4733f1ad-fb84-4327-8a17-2e1bdef24cde" class="">{Anzahl Sturmtage} &quot;ab dem &quot;  {Beginn Datum}</p></div></p><h3 id="008ba5c4-fe71-4723-8a13-6171dd1173a1" class="">Hinweise:</h3><ul id="de017a42-ec6a-45c2-9355-689320e12dc4" class="bulleted-list"><li>Sie dürfen bei der Bearbeitung dieser Aufgabe auf string-Bearbeitungsmethoden
zurückgreifen.</li></ul><ul id="5df53d3c-ccf3-4660-b5af-0cee8dc8a945" class="bulleted-list"><li>Achten Sie auf einen korrekten Umgang mit Dateien (Öffnen/Schliessen). Auf
die Existenz der Datei muss nicht getestet werden.</li></ul><ul id="be45cf66-62bf-4973-b04f-ce4f1b120e70" class="bulleted-list"><li>Ein möglicher Lösungsansatz ist das Mitzählen der aufeinanderfolgenden Zeilen
mit dem besonderen Zustand (Sturm) bzw. dem Zurücksetzen des Zählers,
wenn dieser Zustand nicht besteht. Achten Sie dabei auch darauf, dass auch ein
etwaiger Sturm-Zustand am Dateiende richtig behandelt wird!</li></ul><ul id="e2206afb-3fea-497b-a1ac-582f55f74a82" class="bulleted-list"><li>Das Datum ist in der Datei in kompakter Form JJJJMMTT, also Jahr vierstellig,
Monat zweistellig und Tag zweistellig angegeben. Sie können zum Zerlegen des
Datums auf die üblichen String-Funktionen; z.B. SubString() zurückgreifen.</li></ul><ul id="1537aa61-8665-47b3-a0e9-2171742773c9" class="bulleted-list"><li>Ganz wichtig! Zahlen wie 3.5 sind in der Datei mit einem Punkt (&quot;.&quot;) angegeben.
Convert.ToDouble() erwartet bei deutscher Voreinstellung ein Komma (&quot;,&quot;).
Dies können Sie leicht mit einem String-Replace() bewerkstelligen.</li></ul><hr id="125da86d-064e-4727-ab63-2c52c5eb4dd4"/><p id="ed834bc5-b39c-41d5-94d3-5cbf589a188a" class="">
</p></div></article></body></html>
