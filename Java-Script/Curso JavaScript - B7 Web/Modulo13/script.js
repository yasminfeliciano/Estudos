let B7Validator = {
    handleSubmit:(event) => {
        //evento para prevenir ação padrão
        event.preventDefault();
        let send = true;

        let inputs = form.querySelectorAll('input');

        B7Validator.clearErrors();

        for(let i=0; i<inputs.length;i++){
            let input = inputs[i];
            let check = B7Validator.checkInput(input);
            if(check!==true){
                send = false;
                // exibir o erro
                B7Validator.showError(input)
            }
        }

        if(send){
            form.submit();
        }
    },

    checkInput:(input) => {
        let rules = input.getAttribute('data-rules');

        if (rules!== null){
            //caracter para separar as regras, pode ser qual quer um, nesse caso é ('|').
            rules = rules.split('|');
            for(let k in rules){
                let rDetails = rules[k].split('=');

                switch(rDetails[0]){
                    case 'required':
                        if(input.value == ''){
                            return 'Campo não pode ser vazio.'
                        }
                    break;
                    case 'min':
                        if(input.value.length < rDetails[1]){
                            return 'Campo tem que ter pelo menos '+rDetails[1]+' caracters';
                        }
                    break;
                    case 'email':
                        if(input.value != ''){
                            let regex = /^(([^<>()\[\]\\.,;:\s@"]+(\.[^<>()\[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
                            if(!regex.test(input.value.toLowerCase())) {
                                return 'Email digitado não é válido!';
                            }
                        }
                    break;
                }
            }
        }

        return true;
    },

    showError: (input, error) => {
        //deixar a borda do campo em vermelho
        input.style.borderColor = '#f00'
        //Criar uma div para a mensagem de erro aparecer
        let errorElement = document.createElement('div');
        //adicionar uma classe para a mensagem de erro
        errorElement.classList.add('error');
        //alterar o html para a mensagem de erro
        errorElement.innerHTML = error;

        input.parentElement.insertBefore(errorElement,input.ElementSibling);
    },

    clearErrors:() => {
        let inputs = form.querySelectorAll('input');
        for(let i = 0; i<inputs.length;i++){
            inputs[i].style = '';
        };

        let errorElements = document.querySelectorAll('.error');
        for(let i = 0; i< errorElements.length;i++){
            errorElements[i].remove();
        };
    }
}

let form = document.querySelector('.b7validator');
form.addEventListener('submit', B7Validator.handleSubmit);