﻿module Main

open Browser
open Browser.Types
open System

let phrases = [
    "(554704354792177664)", "Я выжимал 270 раньше"
    "(554704354792177664)", "Играет карту в 67 акки"
    "(554704354792177664)", "Я половину дисита проходил"
    "(767489709021986866)", "Мне чем бигблег нравится там скорость 10 и выше"
    "(767489709021986866)", "Сколько ты бпм выжимаешь максималака"
    "(554704354792177664)", "Ну берсты могу и 500"
    "(554704354792177664)", "Ну берсты это когда много точек в одном месте"
    "(554704354792177664)", "Ну я вот это на ДТшке хочу тут ебучий спам"
    "(767489709021986866)", "Скидывает карты ZXC Cursed"
    "(554704354792177664)", "Ну самое прикольное что я играл на дт это химеру на дт"
    "(554704354792177664)", "Ну я что клоун на B или A играть"
    "(554704354792177664)", "Ну нихуя мне 6к пп затирает за C"
    "(571935583329583124)", "Мои 200 миллионов на карте такие привет"
    "(571935583329583124)", "Пиздец какой гений еще меня пытавлся учить"
    "(726570280864186399)", "Кстати никто не знает но я 3 дигит"
    "(726570280864186399)", "У меня клава 23 тыщи"
    "(930712298962685982)", "Попробуйте мои очки догнать лохи"
    "(930712298962685982)", "Я думаю ты 7 стар осилишь, 7.7, 211 бпм"
    "(338755214930739203)", "Как же я ебашу на 3000 пп"
    "(338755214930739203)", "Ща бы радоваться с 5* ФК"
    "(338755214930739203)", "Было бы смешно если бы я сейчас читы врубил и заспидранил бан"
    "(338755214930739203)", "Так смотрите все ща будет фк UNITED в 3 мода"
    "(540144509674323968)", "Так 230 бпм, 240..."
    "(540144509674323968)", "Это мультиакк или мультибес"
    "(308906067675447296)", "Всего 237 ты че"
    "(184637657597345804)", "8* Джампы сложные? Да нет обычные"
    "(675282088768962591)", "Ну мог бы конечно сразу на 10 идти там бы я точно разогрелся"
    "(675282088768962591)", "Ну однажды без ноуфейла до дропа проходил"
    "(675282088768962591)", "Вот это поинтереснее (включает 10*)"
    "(1083949803513315388)", "Mirror mirror зафармишь и сразу все уважать будут"
    "(1083949803513315388)", "Ну сейв ми это на берсты"
    "(1083949803513315388)", "Я на гатари играю"
    "(1083949803513315388)", "Ну у меня бан на банчо, у меня бан как только на него зашел"
    "(266156948657799169)", "Ну меня на гатари отклонили долбаеб на админах"
    "(987743002522947604)", "Ну у тебя карта слишком медленная, я же 8* прошел"
    "(353537745471143941)", "Есть карта там чисто 190 бпм стрим 9 минут. Я пасснул там ничего сложного (*MORI MORI*)"
    "(353537745471143941)", "А, ладно, без курсорданса"
    "(353537745471143941)", "А что у меня с мсом"
    "(353537745471143941)", "Да бля я с таким мсом играть не могу (2мс)"
    "(353537745471143941)", "Так бля у тебя норм 2 мс потому что ты на мышке"
    "(353537745471143941)", "Я то играю на планшете у меня стилус подключен не напрямую к планшету"
    "(353537745471143941)", "Так потому что у тебя сигналы идут напрямую а у меня через планшет"
    "(353537745471143941)", "Блин как бы не перефармить у меня скоро турнир"
    "(353537745471143941)", "Смотри я берсты в 300 жму!"
    "(284406362941685761)", "В доту зашел? В осу. Это потому что я на мышке играю"
    "(500685579936202752)", "Я оффлайн плеер играю на гатари"
    "(787897165463814154)", "(*System_error*) для людей 12к пп это много и из-за этого такой респект кидают ? чё за мем сейчас вроде не 2016"
    "(787897165463814154)", "Почему 12к пп так любят лоу скилл челики"
    "(787897165463814154)", "мем, я за 20 минут перефармить могу их два аккаунта вместе взятых. Че то пукают сидят"
    "(787897165463814154)", "или мне по пп снайпануть макса , чтобы они траханье охладили"
    "(591863297276510208)", "Хиден научит тебя правильному таймингу нажатию"
    "(591863297276510208)", "Правда если с хиденом поиграешь то с обычных кругов плевать будешь"
    "(591863297276510208)", "Я играл раньше неплохо дт 220 бпм жал"
    "(591863297276510208)", "После того как я сломал на руке все пальцы я теперь только релакс играю"
    "(591863297276510208)", "Ты должен 162.5 бпм хотя бы на S прожать"
    "(591863297276510208)", "Я просто не могу жать я не восстановился"
    "(591863297276510208)", "Берешь запускаешь стрим практис да и все "
    "(591863297276510208)", "Я хочу дт опять дать сукаа"
    "(591863297276510208)", "там еще АР 9 самый противный"
    "(591863297276510208)", "АР 10 самый приятный как по мне"
    "(591863297276510208)", "Квадраты не особо сложные треугольники посложнее будут"
    "(591863297276510208)", "Научится бы тебе фуллскрины жать"
    "(591863297276510208)", "*Показывает полсднее место на акатсуки* Так до сих пор топ держу"
    "(471165284095492116)", "То чувство когда раньше 220 жал а сейчас даже 200 не можешь"
    "(819609834860576848)", "Интересно на каком стриме я в дисите сдохнул"
    "(819609834860576848)", "Это пиздец дисит нельзя пасснуть"
    "(571935583329583124)", "Что я творю! Я просто 3 ноты пережал"
    "(571935583329583124)", "Твой планшет говно мой планшект 10 стоит"
    "(897935682914361355)", "У меня есть шанс вульфа обогнать"
    "(478807201641791509)", "Давайте кто лучше сыграет (спам жим 270)"
    "(726570280864186399)", "190 BPM слишком медленно."
    "(533764926481891360)", "Как играть карты с аром 10.3?"
    "(611201396619870220)", "Играть карты с 11 аром"
    "(533764926481891360)", "Так я меньше чем 10.3 играю, пытаюсь научится играть ноумод"
    "(-1)", "После дт только выходишь начинаешь играть ноумод"
    "(285042291109003264)", "Ну я то даблтапаю сижу мне по кайфу "
    "(967852343230079117)", "На 8* холдить я не буду"
    "(967852343230079117)", "Я не знаю как это пробить"
    "(967852343230079117)", "Че так мало пп дало че за бред"
    "(967852343230079117)", "Саунд химера легкая"
    "(967852343230079117)", "Все мои друзбя пасснули"
    "(967852343230079117)", "Говорит что она легкая в дт когда даже пасснуть не может"
    "(967852343230079117)", "Ща бы хай бпм на вутинге"
    "(725989241280135269)", "У меня друг 8* на мышке играет"
    "(725989241280135269)", "У него 700 с чем-то пп (^)"
    "(1101460168039989279)", "нормальный фонк идет от 4*"
]


let nicknames = [
    "         ?        ", "!70пп помойка"
    "623818798155431938", "типа осер"
    "428092030867079168", "6 digit hyilo"
    "943742708453867570", "учусь играть"
    "852584479493980180", "Химера!?"
    "775288226646720512", "osu!ждаю 2007"
    "285042291109003264", "дайте реквесты"
    "830405950363533355", "осу хуета"
    "583728824672321538", "0pp v osu"
    "482881435795980288", "ничего не сыграна osu"
    "715659920539648123", "без вутинга"
    "420986387861471233", "tabletenjoyer"
    "159706429245095936", "осер и битмарь"
    "695928502632972289", "просто играю в осу"
    "897935682914361355", "подвальный мирами"
    "268752193354465280", "ценитель фонка Elwand"
    "478752139699552268", "noob v osu"
    "715943616849248279", "клавиатурный насильник"
    "420986387861471233", "rx player"
    "695928502632972289", "учусь играть в осу с RX)"
    "716976820846592011", "999999999999pp"
    "852584479493980180", "OSU МОЯ ЖИЗНЬ"
    "981345633308921886", "go multi 1v1"
    "790756038973849610", "# 500пп #какжать180"
    "488995663795978241", "# КАК ИГРАТЬ ДТ ТАП ИКСОМ"
    "967852343230079117", "worst ru player"
]

let mutable prevId = "";

let modifyName (name : string) =
    "@" + name.Replace("(", "").Replace(")", "")

let addPhrase (d: HTMLDivElement) (phrase : string * string) = 
    let author = fst phrase
    let phrase = snd phrase

    if prevId <> author then
        let br = document.createElement "br"
        d.appendChild br |> ignore
        prevId <- author

    let phraseBox : HTMLDivElement = unbox document.createElement "div"
    phraseBox.className <- "osu-card"

    let authorSpan : HTMLSpanElement = unbox document.createElement "span"
    let phraseSpan : HTMLSpanElement = unbox document.createElement "span"

    authorSpan.textContent <- modifyName author
    phraseSpan.textContent <- phrase

    phraseBox.appendChild authorSpan |> ignore
    phraseBox.appendChild phraseSpan |> ignore

    d.appendChild phraseBox |> ignore


let showRandomPhrase _ =
    let phrase = phrases[(new Random()).Next() % phrases.Length]
    let author = fst phrase |> modifyName
    let phrase = snd phrase
    let authorholder : HTMLSpanElement = unbox document.getElementById "random-phrase-author-span"
    let phraseholder : HTMLSpanElement = unbox document.getElementById "random-phrase-span"
    let dialog : HTMLDialogElement = unbox document.getElementById "random-phrase-dialog"
    authorholder.innerText <- author
    phraseholder.innerText <- phrase
    dialog.show()


let registerRandomButton () =
    let btn : HTMLButtonElement = unbox document.getElementById "random-phrase-button"
    btn.onclick <- showRandomPhrase


[<EntryPoint>]
let main _ =
    let phrasesDiv : HTMLDivElement = unbox document.getElementById "phrases"
    let nicknamesDiv : HTMLDivElement = unbox document.getElementById "nicknames"

    let sortedPhrases = List.sortBy fst phrases
    let sortedNicknames = List.sortBy fst nicknames

    Seq.iter (addPhrase phrasesDiv) sortedPhrases
    Seq.iter (addPhrase nicknamesDiv) sortedNicknames

    registerRandomButton ()

    0 (* Ok *)
