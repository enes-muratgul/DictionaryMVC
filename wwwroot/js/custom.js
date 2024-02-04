function updateDictionary() {
    var inputText = document.getElementById('burayaz').value;
    var dictionaryHeading = document.querySelector('.center h1');
    dictionaryHeading.innerText = inputText || 'Sozluk';
}


function kayit_yonlendir() {
    window.location.href = '/Account/Register';
}
function giris_yonlendir() {
    window.location.href = '/Home/Privacy';
}

function showAddWordModal() {
    var modal = document.getElementById('addWordModal');
    modal.style.display = 'block';
}

function hideAddWordModal() {
    var modal = document.getElementById('addWordModal');
    modal.style.display = 'none';
}
// custom.js dosyası

function showAddWordModal() {
    document.getElementById('addWordModal').style.display = 'block';
}

function hideAddWordModal() {
    document.getElementById('addWordModal').style.display = 'none';
}

function updateDictionary() {
    // Burada sözlüğün güncellenmesi için gerekli işlemleri yapabilirsiniz.
}

// Form submit olduğunda tetiklenecek fonksiyon
document.addEventListener('DOMContentLoaded', function () {
    var form = document.querySelector('.add-word-form form');

    form.addEventListener('submit', function (event) {
        event.preventDefault(); // Sayfanın yenilenmesini engeller

        var newWord = form.querySelector('input[name="newWord"]').value;
        var newSentence = form.querySelector('input[name="newSentence"]').value;

        // Tabloya yeni kelime ve cümleyi ekleme
        var table = document.querySelector('table');
        var newRow = table.insertRow(-1); // Tabloya yeni bir satır ekler

        var wordCell = newRow.insertCell(0); // Kelime hücresi oluşturur
        wordCell.textContent = "Kelime: " + newWord + ", Cümle: " + newSentence;

        var sentenceCell = newRow.insertCell(1); // Cümle hücresi oluşturur
        sentenceCell.textContent = "Kelime: " + newWord + ", Cümle: " + newSentence;

        // Formu sıfırla
        form.reset();
        hideAddWordModal();
    });
});
