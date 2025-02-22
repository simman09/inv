import { InventoryManagementTemplatePage } from './app.po';

describe('InventoryManagement App', function() {
  let page: InventoryManagementTemplatePage;

  beforeEach(() => {
    page = new InventoryManagementTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
