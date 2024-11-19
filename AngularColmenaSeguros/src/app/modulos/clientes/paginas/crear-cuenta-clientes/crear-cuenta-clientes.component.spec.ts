import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CrearCuentaClientesComponent } from './crear-cuenta-clientes.component';

describe('CrearCuentaClientesComponent', () => {
  let component: CrearCuentaClientesComponent;
  let fixture: ComponentFixture<CrearCuentaClientesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [CrearCuentaClientesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(CrearCuentaClientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
