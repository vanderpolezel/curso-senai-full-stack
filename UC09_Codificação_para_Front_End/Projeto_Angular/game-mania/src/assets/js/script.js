console.log("ola Mundo!!!")

function cadastrarNewsletter() {
    let email = document.getElementById("campo-email").value

    alert(email)
    console.log(email)
}

function mouseoverPass(obj) {
    var obj = document.getElementById('myPassword');
    obj.type = "text";
  }
  function mouseoutPass(obj) {
    var obj = document.getElementById('myPassword');
    obj.type = "password";
  }
      
