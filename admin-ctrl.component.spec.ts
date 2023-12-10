import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AdminCtrlComponent } from './admin-ctrl.component';

describe('AdminCtrlComponent', () => {
  let component: AdminCtrlComponent;
  let fixture: ComponentFixture<AdminCtrlComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AdminCtrlComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(AdminCtrlComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
