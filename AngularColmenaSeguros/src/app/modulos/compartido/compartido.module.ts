import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MenuComponent } from './componentes/menu/menu.component';
import { CarruselComponent } from './componentes/carrusel/carrusel.component';



@NgModule({
  declarations: [
    MenuComponent,
    CarruselComponent
  ],
  imports: [
    CommonModule
  ],
  exports: [
    MenuComponent,
    CarruselComponent
  ]
})
export class CompartidoModule { }
