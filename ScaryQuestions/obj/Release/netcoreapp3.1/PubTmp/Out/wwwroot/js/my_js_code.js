var safe = [];
var quastions = [];
var random_index;
var control_num = 2;
async function GetQuastions() {
    // отправляет запрос и получаем ответ
         const response = await fetch("/api/crud", {

        method: "GET",
        headers: {
            "Accept": "application/json"
        }
    });
    if (response.ok === true) {
        // если запрос прошел нормально
        // получаем данные
        quastions = await response.json();
    }

}
GetQuastions();

function ChangeQuastion(y_n) {
    // ПРОВЕРЯЕМ, ИДУТ ЛИ ВОПРОСЫ ПО ВТОРОМУ КУРУГ
    if (control_num == 2) {
        document.getElementById("btn_place").classList.remove("d-none");
        document.getElementById("btn_first").classList.add("d-none");
        control_num = 1;

    }
    if (safe.length <= quastions.length) {
        control_num = 1;
        var save_the_passed_element = y_n;
        this.random_index = Math.floor(Math.random() * quastions.length);

        // ПРОВЕРЯЕМ, ПОВТОРЯЕТСЯ ЛИ ВОПРОС
        if (safe.indexOf(quastions[random_index].id) !== -1) {
            ChangeQuastion("no");
        }
        safe.push(quastions[random_index].id);

        document.getElementById("quastion_place").innerHTML = quastions[random_index].theQuestion;
        document.getElementById("like").innerHTML = quastions[random_index].likeForQuestion;
        document.getElementById("dislike").innerHTML = quastions[random_index].dislikeForQuestion;
        document.getElementById("IdOfTheRequiredQuestion").value = quastions[random_index].id;
        document.getElementById("YesOrNo").value = y_n;
        if (y_n == 'start') {
            return;
        }
        sendAjaxForm('result_form', 'ajax_form', '/riddler/QuestionGenerator');
    } else {

        if (control_num == 1) {
            document.getElementById("btn_place").classList.add("d-none");
            document.getElementById("btn").classList.remove("d-none");
            document.getElementById("quastion_place").innerHTML = '...';
            control_num = 0;
        } else {
            document.getElementById("btn_place").classList.remove("d-none");
            document.getElementById("btn").classList.add("d-none");
            safe = [];
            ChangeQuastion('start');
        }


        return;
    }




}

function remove_textarea(id) {
    document.getElementById(id).value = '';
}