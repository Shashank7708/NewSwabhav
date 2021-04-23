import { TestBed } from '@angular/core/testing';

import { AddresServiceService } from './addres-service.service';

describe('AddresServiceService', () => {
  let service: AddresServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(AddresServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
