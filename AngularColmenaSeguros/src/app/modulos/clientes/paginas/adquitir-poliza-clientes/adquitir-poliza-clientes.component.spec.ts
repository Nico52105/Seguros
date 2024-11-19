import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdquitirPolizaClientesComponent } from './adquitir-poliza-clientes.component';

describe('AdquitirPolizaClientesComponent', () => {
  let component: AdquitirPolizaClientesComponent;
  let fixture: ComponentFixture<AdquitirPolizaClientesComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [AdquitirPolizaClientesComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdquitirPolizaClientesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
