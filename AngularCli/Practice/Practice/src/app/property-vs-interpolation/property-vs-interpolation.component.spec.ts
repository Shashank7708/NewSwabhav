import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PropertyVsInterpolationComponent } from './property-vs-interpolation.component';

describe('PropertyVsInterpolationComponent', () => {
  let component: PropertyVsInterpolationComponent;
  let fixture: ComponentFixture<PropertyVsInterpolationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PropertyVsInterpolationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PropertyVsInterpolationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
