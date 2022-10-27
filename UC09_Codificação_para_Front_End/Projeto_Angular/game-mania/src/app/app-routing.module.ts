import { CabecalhoComponent } from './componentes/cabecalho/cabecalho.component';
import { BannerCarrosselComponent } from './componentes/banner/banner-carrossel/banner-carrossel.component';



import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ListaJogosComponent } from './componentes/jogos/lista-jogos/lista-jogos.component';
import { LoginComponent } from './componentes/login/login.component';



const routes: Routes = [
 
  {path:"", component:ListaJogosComponent},
  {path:"", component:BannerCarrosselComponent},
  {path:"",component:CabecalhoComponent},
  {path:"login", component: LoginComponent}
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
