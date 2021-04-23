import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HttpClient1Component } from './http-client1.component';

describe('HttpClient1Component', () => {
  let component: HttpClient1Component;
  let fixture: ComponentFixture<HttpClient1Component>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HttpClient1Component ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HttpClient1Component);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
