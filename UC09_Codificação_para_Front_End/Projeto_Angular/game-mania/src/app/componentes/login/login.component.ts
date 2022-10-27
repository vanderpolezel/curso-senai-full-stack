import { User } from './../../model/user';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }
 
  ngOnInit(): void {
  }  

  userModel = new User();


  receberDados() {
    console.log(this.userModel)
    alert(this.userModel.email)
    alert(this.userModel.password)

  }

}
