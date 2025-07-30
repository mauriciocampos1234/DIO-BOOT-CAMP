window.onload = function(e) {

    var btnCadastrar = document.getElementById("btnCadastrar");
    var txtNome = document.getElementById("txtNome");
    var txtSobreNome = document.getElementById("txtSobreNome");
    var txtEmail = document.getElementById("txtEmail");
    var txtTelefone = document.getElementById("txtTelefone");
    var slcGenero = document.getElementById("slcGenero");
    var txtSenha = document.getElementById("txtSenha");

    txtNome.focus(); // Assim que carrega a página já pisca a | no primeio campo

    btnCadastrar.onclick = function (e) {
        e.preventDefault();

        var nome = txtNome.value;
        var sobrenome = txtSobreNome.value;
        var email = txtEmail.value;
        var telefone = txtTelefone.value;
        var genero = slcGenero.value
        var senha = txtSenha.value;

        if (nome == "") {
            exibirMensagemErro("Campo nome é obrigatório.");
        } 
        else if (sobrenome == "") { 
            exibirMensagemErro("Campo sobrenome é obrigatório."); 
        } 
        else if (email == "") {
            exibirMensagemErro("Campo e-mail é obrigatório.");
        } 
        else if (telefone == "") {
            exibirMensagemErro("Campo telefone é obrigatório.");
        }
        else if (genero == "") {
            exibirMensagemErro("Campo gênero é obrigatório.");
        }
        else if (senha == "") {
            exibirMensagemErro("Campo senha é obrigatório.");
        } 
        else {
            cadastrar(nome, sobrenome, email, telefone, genero, senha);
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

    function cadastrar(nome, sobrenome, email, telefone, genero, senha) {
        
        var data = JSON.stringify({
            "nome": nome,
            "sobrenome": sobrenome,
            "email": email,
            "telefone": telefone,
            "genero": genero,
            "senha": senha


        });

        var xhr = new XMLHttpRequest();
        xhr.withCredentials = true;

        xhr.addEventListener("readystatechange", function () {
            if (this.readyState === 4) {

                var result = JSON.parse(this.responseText);

                if (result.sucesso) {
                    alert("Cadastrou via API!")
                } else {
                    exibirMensagemErro(result.mensagem);
                }
            }
        });

        xhr.open("POST", "https://localhost:44398/api/usuario/cadastro");
        xhr.setRequestHeader("Content-Type", "application/json");

        xhr.send(data);
    }
};
