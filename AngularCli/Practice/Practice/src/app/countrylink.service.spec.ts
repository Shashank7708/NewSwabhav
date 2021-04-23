import { TestBed } from '@angular/core/testing';

import { CountrylinkService } from './countrylink.service';

describe('CountrylinkService', () => {
  let service: CountrylinkService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CountrylinkService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
