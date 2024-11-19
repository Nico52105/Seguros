import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-menu',
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent {
  Menu: { menu: string, ruta: string }[] = [
    { menu: 'Inicio', ruta: 'bienvenido' },
    { menu: 'Servicios', ruta: 'servicios' },
    { menu: 'Cotización', ruta: 'cotizacion' }
  ];

  constructor(private router: Router) {}

  redireccionar(ruta: string) {
    this.router.navigate(["./"+ruta]);
  }
}
