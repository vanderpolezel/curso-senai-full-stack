import { LoginService } from './../../services/login.service';
import { User } from './../../model/user';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private LoginService: LoginService, private router: Router) { }
 
  ngOnInit(): void {
  }  

  userModel = new User();

  mensagem = ""


  receberDados() {
    console.log(this.userModel)
    // alert(this.userModel.email)
    // alert(this.userModel.password)

    this.LoginService.login(this.userModel).subscribe( (response) => {
      console.log("Deu certo")   
      localStorage.setItem("usuario", response.body.user.nome)
      this.router.navigateByUrl("/")
      
    }, (respostaErro) => {
      console.log("Deu erro")
      this.mensagem = respostaErro.error

    //   if (respostaErro.error == "Password is too short") {
    //   this.mensagem = "Senha muito curta"
    // } else {
    //   this.mensagem = respostaErro.error
    // }
      // alert(respostaErro.error)

    } )
  }

}
