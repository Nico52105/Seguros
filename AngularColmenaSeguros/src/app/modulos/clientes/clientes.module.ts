import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ClientesRoutingModule } from './clientes-routing.module';

import { CompartidoModule } from '../compartido/compartido.module';

import { LayoutClientesComponent } from './layout/layout-clientes/layout-clientes.component';
import { InicioClientesComponent } from './paginas/inicio-clientes/inicio-clientes.component';
import { ServiciosClientesComponent } from './paginas/servicios-clientes/servicios-clientes.component';
import { CotizacionClientesComponent } from './paginas/cotizacion-clientes/cotizacion-clientes.component';
import { CrearCuentaClientesComponent } from './paginas/crear-cuenta-clientes/crear-cuenta-clientes.component';
import { AdquitirPolizaClientesComponent } from './paginas/adquitir-poliza-clientes/adquitir-poliza-clientes.component';
import { PolizasClientesComponent } from './paginas/polizas-clientes/polizas-clientes.component';
import { AplicarPolizaClientesComponent } from './paginas/aplicar-poliza-clientes/aplicar-poliza-clientes.component';



@NgModule({
  declarations: [
    LayoutClientesComponent,
    InicioClientesComponent,
    ServiciosClientesComponent,
    CotizacionClientesComponent,
    CrearCuentaClientesComponent,
    AdquitirPolizaClientesComponent,
    PolizasClientesComponent,
    AplicarPolizaClientesComponent
  ],
  imports: [
    CommonModule,
    ClientesRoutingModule,
    CompartidoModule
  ]
})
export class ClientesModule { }
