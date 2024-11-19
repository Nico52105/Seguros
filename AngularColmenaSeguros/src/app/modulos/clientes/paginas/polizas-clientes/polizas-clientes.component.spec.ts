import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PolizasClientesComponent } from './polizas-clientes.component';

describe('PolizasClientesComponent', () => {
  let component: PolizasClientesComponent;
  let fixture: ComponentFixture<PolizasClientesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [PolizasClientesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PolizasClientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
