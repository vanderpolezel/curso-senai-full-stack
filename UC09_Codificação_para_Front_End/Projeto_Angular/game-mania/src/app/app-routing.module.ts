import { LoginComponent } from './componentes/login/login.component';
import { BannerCarrosselComponent } from './componentes/banner/banner-carrossel/banner-carrossel.component';
import { ListaJogosComponent } from './componentes/jogos/lista-jogos/lista-jogos.component';


import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';



const routes: Routes = [
  { path: "", component: ListaJogosComponent }, 
  { path: "login", component: LoginComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
