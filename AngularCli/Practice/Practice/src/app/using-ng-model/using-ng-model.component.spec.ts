import { ComponentFixture, TestBed } from '@angular/core/testing';

import { UsingNgModelComponent } from './using-ng-model.component';

describe('UsingNgModelComponent', () => {
  let component: UsingNgModelComponent;
  let fixture: ComponentFixture<UsingNgModelComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ UsingNgModelComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(UsingNgModelComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
