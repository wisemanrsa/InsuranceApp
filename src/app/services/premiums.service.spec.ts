import { TestBed } from '@angular/core/testing';

import { PremiumsService } from './premiums.service';

describe('PremiumsService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: PremiumsService = TestBed.get(PremiumsService);
    expect(service).toBeTruthy();
  });
});
