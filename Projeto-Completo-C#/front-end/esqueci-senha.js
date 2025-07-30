window.onload = function(e) {

    var btnRecuperarSenha = document.getElementById("btnRecuperarSenha");
    

    txtEmail.focus(); // Assim que carrega a página já pisca a |

    btnRecuperarSenha.onclick = function (e) {
        e.preventDefault();

        var email = txtEmail.value;
        

        if (email == "") {
            exibirMensagemErro("Campo E-mail obrigatório.");
        } else {
            recuperarSenha(email);
        }
    };

    function exibirMensagemErro(mensagem) {
        var spnErro = document.getElementById("spnErro");

        spnErro.innerText = mensagem;
        spnErro.style.display = "block";

        setTimeout(function () {
            spnErro.style.display = "none";
        }, 3000);
    }

    function recuperarSenha(email) {
        
        var data = JSON.stringify({
            "email": email
        });

        var xhr = new XMLHttpRequest();
        xhr.withCredentials = true;

        xhr.addEventListener("readystatechange", function () {
            if (this.readyState === 4) {

                var result = JSON.parse(this.responseText);

                if (result.sucesso) {
                    alert ("E-mail enviado com sucesso via API.")
                } else {
                    exibirMensagemErro(result.mensagem);
                }
            }
        });

        xhr.open("POST", "https://localhost:44398/api/usuario/esqueceuSenha");
        xhr.setRequestHeader("Content-Type", "application/json");

        xhr.send(data);
    }
};
