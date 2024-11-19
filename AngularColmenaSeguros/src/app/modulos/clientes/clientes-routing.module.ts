import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LayoutClientesComponent } from './layout/layout-clientes/layout-clientes.component';
import { InicioClientesComponent } from './paginas/inicio-clientes/inicio-clientes.component';
import { AplicarPolizaClientesComponent } from './paginas/aplicar-poliza-clientes/aplicar-poliza-clientes.component';
import { AdquitirPolizaClientesComponent } from './paginas/adquitir-poliza-clientes/adquitir-poliza-clientes.component';
import { CotizacionClientesComponent } from './paginas/cotizacion-clientes/cotizacion-clientes.component';
import { CrearCuentaClientesComponent } from './paginas/crear-cuenta-clientes/crear-cuenta-clientes.component';
import { ServiciosClientesComponent } from './paginas/servicios-clientes/servicios-clientes.component';
import { PolizasClientesComponent } from './paginas/polizas-clientes/polizas-clientes.component';

const routes: Routes = [
  {
    path: '',
    component: LayoutClientesComponent,
    children: [
      {
        path: '',
        redirectTo: 'bienvenido',
        pathMatch: 'full'
      },
      {
        path: 'bienvenido',
        component: InicioClientesComponent,
      },
      {
        path: 'servicios',
        component: ServiciosClientesComponent,
      },
      {
        path: 'cotizacion',
        component: CotizacionClientesComponent,
      },
      {
        path: 'registrarme',
        component: CrearCuentaClientesComponent,
      },
      {
        path: 'asegurar',
        component: AdquitirPolizaClientesComponent,
      },
      {
        path: 'misprotecciones',
        component: PolizasClientesComponent,
      },
      {
        path: 'coberturas',
        component: AplicarPolizaClientesComponent,
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ClientesRoutingModule { }
