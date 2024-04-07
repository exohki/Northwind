document.addEventListener("DOMContentLoaded", function() {
    document.getElementById('discount-row').addEventListener('click', function(e){
        e.preventDefault();
        var toast = bootstrap.Toast.getOrCreateInstance(document.getElementById('liveToast'));
        toast.show();
        playToastSound(); 
    });

    function playToastSound() {
        var audio = document.getElementById('toastSound');
        audio.play();
    }
});
