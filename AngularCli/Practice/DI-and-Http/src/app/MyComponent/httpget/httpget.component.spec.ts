import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HttpgetComponent } from './httpget.component';

describe('HttpgetComponent', () => {
  let component: HttpgetComponent;
  let fixture: ComponentFixture<HttpgetComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HttpgetComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HttpgetComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
