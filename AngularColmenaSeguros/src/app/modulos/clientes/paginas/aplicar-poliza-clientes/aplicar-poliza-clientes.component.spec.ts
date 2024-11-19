import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AplicarPolizaClientesComponent } from './aplicar-poliza-clientes.component';

describe('AplicarPolizaClientesComponent', () => {
  let component: AplicarPolizaClientesComponent;
  let fixture: ComponentFixture<AplicarPolizaClientesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AplicarPolizaClientesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AplicarPolizaClientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
