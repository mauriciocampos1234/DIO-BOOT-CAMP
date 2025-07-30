window.onload = function(e) {

    var btnEntrar = document.getElementById("btnEntrar");
    var txtEmail = document.getElementById("txtEmail");
    var txtSenha = document.getElementById("txtSenha");

    txtEmail.focus(); // Assim que carrega a página já pisca a |

    btnEntrar.onclick = function (e) {
        e.preventDefault();

        var email = txtEmail.value;
        var senha = txtSenha.value;

        if (email == "") {
            exibirMensagemErro("Campo E-mail obrigatório.");
        } else if (senha == "") { 
            exibirMensagemErro("Campo Senha obrigatório."); 
        } else {
            realizarLogin(email, senha);
        }
    };

    function exibirMensagemErro(mensagem) {
        var spnErro = document.getElementById("spnErro");

        spnErro.innerText = mensagem;
        spnErro.style.display = "block";

        setTimeout(function () {
            spnErro.style.display = "none";
        }, 4000);
    }

    function realizarLogin(email, senha) {
        
        //Padrão do postman, só troca os valores fixos pelos atributos
        //var data = JSON.stringify({
            //"email": email,
            //"senha": senha
        //});

        //Ou pode ser assim:
        var login = {
            "email": email,
            "senha": senha
        }
        var data = JSON.stringify(login);

        ///////////////////////////////////////////


        var xhr = new XMLHttpRequest();
        xhr.withCredentials = true;

        xhr.addEventListener("readystatechange", function () {
            if (this.readyState === 4) {

                var loginResult = JSON.parse(this.responseText);

                if (loginResult.sucesso) {
                    alert('Logou via API')
                } else {
                    exibirMensagemErro(loginResult.mensagem);
                }
            }
        });

        xhr.open("POST", "https://localhost:44398/api/usuario/login");
        xhr.setRequestHeader("Content-Type", "application/json");

        xhr.send(data);
    }
};
