/*
* Created by SharpDevelop.
* User: tmontauf040213
* Date: 26/12/2013
* Time: 17:04
*
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
*/
using System;
using System.Windows.Forms;

namespace Explorer
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class RichExplorer : Form
    {
        #region Attribute
        private Ribbon _ribbon;
        private RibbonTab _tabWelcome;
        private RibbonTab _tabSharing;
        private RibbonTab _tabDisplay;

        private RibbonPanel _panelClipBoard;
        private RibbonPanel _panelOrganisation;
        private RibbonPanel _panelNew;
        private RibbonPanel _panelOpen;
        private RibbonPanel _panelSelection;
        private RibbonButton _pinInQuickAccess;
        private RibbonButton _copy;
        private RibbonButton _paste;
        private RibbonButton _cut;
        private RibbonButton _copyAccessPath;
        private RibbonButton _pasteShortcut;
        private RibbonButton _moveTo;
        private RibbonButton _copyTo;
        private RibbonButton _delete;
        private RibbonButton _rename;
        private RibbonButton _newFolder;
        private RibbonButton _newElement;
        private RibbonButton _quickAccess;
        private RibbonButton _properties;
        private RibbonButton _open;
        private RibbonButton _edit;
        private RibbonButton _history;
        private RibbonButton _selectAll;
        private RibbonButton _selectNone;
        private RibbonButton _selectInvert;

        private RibbonPanel _panelSend;
        private RibbonPanel _panelShareWith;
        private RibbonPanel _panelSecurity;
        private RibbonButton _share;
        private RibbonButton _mail;
        private RibbonButton _zip;
        private RibbonButton _burn;
        private RibbonButton _print;
        private RibbonButton _fax;
        private RibbonButtonList _sharingGroups;
        private RibbonButton _stopSharing;
        private RibbonButton _advancedSecurity;

        private RibbonPanel _panelComponent;
        private RibbonPanel _panelDisposition;
        private RibbonPanel _panelCurrentDisplay;
        private RibbonPanel _panelDisplayHide;
        private RibbonButton _componentNavitation;
        private RibbonButton _componentVisualisation;
        private RibbonButton _componentDetails;
        private RibbonButtonList _dispositionList;
        private RibbonButton _veryBigIcon;
        private RibbonButton _bigIcon;
        private RibbonButton _mediumIcon;
        private RibbonButton _smallIcon;
        private RibbonButton _listIcon;
        private RibbonButton _detailIcon;
        private RibbonButton _mosaiqueIcon;
        private RibbonButton _contentIcon;
        private RibbonButton _sort;
        private RibbonButton _groupBy;
        private RibbonButton _addColumns;
        private RibbonButton _adjustColumnsSize;
        private RibbonCheckBox _compenentCheckBoxes;
        private RibbonCheckBox _fileExtentionDisplay;
        private RibbonCheckBox _displayHidenComponents;
        private RibbonButton _hideSelectedComponents;
        private RibbonButton _options;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public RichExplorer()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            _ribbon = new Ribbon();
            _ribbon.Height = 150;
            _ribbon.OrbStyle = RibbonOrbStyle.Office_2013;
            _ribbon.OrbText = "Fichier";
            this.Controls.Add(_ribbon);

            BuildTabWelcome();
            BuildTabSharing();
            BuildTabDisplay();
        }
        private void BuildTabWelcome()
        {
            _tabWelcome = new RibbonTab("Accueil");
            _ribbon.Tabs.Add(_tabWelcome);

            #region ClipBoard
            _panelClipBoard = new RibbonPanel("Presse-papiers");
            _panelClipBoard.Image = Tools4Libraries.Resources.ResourceIconSet16Default.pressePapier;
            _tabWelcome.Panels.Add(_panelClipBoard);

            _pinInQuickAccess = new RibbonButton("Epingler dans accès rapide");
            _pinInQuickAccess.MinSizeMode = RibbonElementSizeMode.Large;
            _pinInQuickAccess.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.pin;
            _panelClipBoard.Items.Add(_pinInQuickAccess);

            _copy = new RibbonButton("Copier");
            _copy.MinSizeMode = RibbonElementSizeMode.Large;
            _copy.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.copy;
            _panelClipBoard.Items.Add(_copy);

            _paste = new RibbonButton("Coller");
            _paste.MinSizeMode = RibbonElementSizeMode.Large;
            _paste.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.paste;
            _panelClipBoard.Items.Add(_paste);

            _cut = new RibbonButton("Couper");
            _cut.MaxSizeMode = RibbonElementSizeMode.Medium;
            _cut.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.cut;
            _panelClipBoard.Items.Add(_cut);

            _copyAccessPath = new RibbonButton("Copier le chemin d'accès");
            _copyAccessPath.MaxSizeMode = RibbonElementSizeMode.Medium;
            _copyAccessPath.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.path;
            _panelClipBoard.Items.Add(_copyAccessPath);

            _pasteShortcut = new RibbonButton("Coller le raccourci");
            _pasteShortcut.MaxSizeMode = RibbonElementSizeMode.Medium;
            _pasteShortcut.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.shortcut;
            _panelClipBoard.Items.Add(_pasteShortcut);
            #endregion

            #region Organisation
            _panelOrganisation = new RibbonPanel("Organiser");
            _panelOrganisation.Image = Tools4Libraries.Resources.ResourceIconSet16Default.delete;
            _tabWelcome.Panels.Add(_panelOrganisation);

            _moveTo = new RibbonButton("Déplacer vers");
            _moveTo.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.moveto;
            _moveTo.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.moveto;
            _panelOrganisation.Items.Add(_moveTo);

            _copyTo = new RibbonButton("Copier vers");
            _copyTo.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.copyto;
            _copyTo.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.copyto;
            _panelOrganisation.Items.Add(_copyTo);

            _delete = new RibbonButton("Supprimer");
            _delete.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.delete;
            _delete.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.delete;
            _panelOrganisation.Items.Add(_delete);

            _rename = new RibbonButton("Renommer");
            _rename.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.rename;
            _rename.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.rename;
            _panelOrganisation.Items.Add(_rename);
            #endregion

            #region New
            _panelNew = new RibbonPanel("Nouveau");
            _panelNew.Image = Tools4Libraries.Resources.ResourceIconSet16Default.folder;
            _tabWelcome.Panels.Add(_panelNew);

            _newFolder = new RibbonButton("Nouveau dossier");
            _newFolder.MinSizeMode = RibbonElementSizeMode.Large;
            _newFolder.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.folder;
            _panelNew.Items.Add(_newFolder);

            _newElement = new RibbonButton("Nouvel élément");
            _newElement.MaxSizeMode = RibbonElementSizeMode.Medium;
            _newElement.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.newElement;
            _panelNew.Items.Add(_newElement);

            _quickAccess = new RibbonButton("Accès rapide");
            _quickAccess.MaxSizeMode = RibbonElementSizeMode.Medium;
            _quickAccess.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.quickAccess;
            _panelNew.Items.Add(_quickAccess);

            #endregion

            #region Open
            _panelOpen = new RibbonPanel("Ouvrir");
            _panelOpen.Image = Tools4Libraries.Resources.ResourceIconSet16Default.open;
            _tabWelcome.Panels.Add(_panelOpen);

            _properties = new RibbonButton("Propriétés");
            _properties.MinSizeMode = RibbonElementSizeMode.Large;
            _properties.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.properties;
            _panelOpen.Items.Add(_properties);

            _open = new RibbonButton("Ouvrir");
            _open.MaxSizeMode = RibbonElementSizeMode.Medium;
            _open.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.open;
            _panelOpen.Items.Add(_open);

            _edit = new RibbonButton("Editer");
            _edit.MaxSizeMode = RibbonElementSizeMode.Medium;
            _edit.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.modify;
            _panelOpen.Items.Add(_edit);

            _history = new RibbonButton("Historique");
            _history.MaxSizeMode = RibbonElementSizeMode.Medium;
            _history.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.history;
            _panelOpen.Items.Add(_history);
            #endregion

            #region Selection
            _panelSelection = new RibbonPanel("Selection");
            _panelSelection.Image = Tools4Libraries.Resources.ResourceIconSet16Default.select;
            _tabWelcome.Panels.Add(_panelSelection);

            _selectAll = new RibbonButton("Tout sélectionner");
            _selectAll.MaxSizeMode = RibbonElementSizeMode.Medium;
            _selectAll.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.select;
            _panelSelection.Items.Add(_selectAll);

            _selectNone = new RibbonButton("Aucun");
            _selectNone.MaxSizeMode = RibbonElementSizeMode.Medium;
            _selectNone.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.selectnone;
            _panelSelection.Items.Add(_selectNone);

            _selectInvert = new RibbonButton("Inverser la sélection");
            _selectInvert.MaxSizeMode = RibbonElementSizeMode.Medium;
            _selectInvert.MinSizeMode = RibbonElementSizeMode.Medium;
            _selectInvert.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.selectinvert;
            _panelSelection.Items.Add(_selectInvert);
            #endregion
        }
        private void BuildTabSharing()
        {
            _tabSharing = new RibbonTab("Partage");
            _ribbon.Tabs.Add(_tabSharing);

            #region Sending
            _panelSend = new RibbonPanel("Envoyer");
            _panelSend.Image = Tools4Libraries.Resources.ResourceIconSet16Default.email2;
            _tabSharing.Panels.Add(_panelSend);

            _share = new RibbonButton("Partager");
            _share.MinSizeMode = RibbonElementSizeMode.Large;
            _share.Image = Tools4Libraries.Resources.ResourceIconSet32Default.share;
            _panelSend.Items.Add(_share);

            _mail = new RibbonButton("Courrier électronique");
            _mail.MinSizeMode = RibbonElementSizeMode.Large;
            _mail.Image = Tools4Libraries.Resources.ResourceIconSet32Default.email2;
            _panelSend.Items.Add(_mail);

            _zip = new RibbonButton("Zipper");
            _zip.MinSizeMode = RibbonElementSizeMode.Large;
            _zip.Image = Tools4Libraries.Resources.ResourceIconSet32Default.zip;
            _panelSend.Items.Add(_zip);

            _burn = new RibbonButton("Graver");
            _burn.MaxSizeMode = RibbonElementSizeMode.Medium;
            _burn.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.cd_burn2;
            _panelSend.Items.Add(_burn);

            _print = new RibbonButton("Imprimer");
            _print.MaxSizeMode = RibbonElementSizeMode.Medium;
            _print.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.printer2;
            _panelSend.Items.Add(_print);

            _fax = new RibbonButton("Télécopie");
            _fax.MaxSizeMode = RibbonElementSizeMode.Medium;
            _fax.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.fax2;
            _panelSend.Items.Add(_fax);
            #endregion

            #region Share with
            _panelShareWith = new RibbonPanel("Partager avec");
            _tabSharing.Panels.Add(_panelShareWith);

            _sharingGroups = new RibbonButtonList();
            _panelShareWith.Items.Add(_sharingGroups);

            _stopSharing = new RibbonButton("Cesser de partage");
            _stopSharing.MinSizeMode = RibbonElementSizeMode.Large;
            _stopSharing.Image = Tools4Libraries.Resources.ResourceIconSet32Default.securityLock;
            _panelShareWith.Items.Add(_stopSharing);
            #endregion

            #region Security
            _panelSecurity = new RibbonPanel(); ;
            _tabSharing.Panels.Add(_panelSecurity);

            _advancedSecurity = new RibbonButton("Sécurité avancée");
            _advancedSecurity.MinSizeMode = RibbonElementSizeMode.Large;
            _advancedSecurity.Image = Tools4Libraries.Resources.ResourceIconSet32Default.security;
            _panelSecurity.Items.Add(_advancedSecurity);
            #endregion
        }
        private void BuildTabDisplay()
        {
            _tabDisplay = new RibbonTab("Affichage");
            _ribbon.Tabs.Add(_tabDisplay);

            #region Component
            _panelComponent = new RibbonPanel("Volets");
            _tabDisplay.Panels.Add(_panelComponent);

            _componentNavitation = new RibbonButton("Volet de navigation");
            _componentNavitation.MinSizeMode = RibbonElementSizeMode.Large;
            _componentNavitation.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.navigation;
            _panelComponent.Items.Add(_componentNavitation);

            _componentVisualisation = new RibbonButton("Volet de visualisation");
            _componentVisualisation.MaxSizeMode = RibbonElementSizeMode.Medium;
            _componentVisualisation.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.windowVisualisation;
            _panelComponent.Items.Add(_componentVisualisation);

            _componentDetails = new RibbonButton("Volet des détails");
            _componentDetails.MaxSizeMode = RibbonElementSizeMode.Medium;
            _componentDetails.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.windowdetail;
            _panelComponent.Items.Add(_componentDetails);
            #endregion

            #region Disposition
            _panelDisposition = new RibbonPanel("Disposition");
            _panelDisposition.Image = Tools4Libraries.Resources.ResourceIconSet16Default.mosaique;
            _tabDisplay.Panels.Add(_panelDisposition);

            _dispositionList = new RibbonButtonList();
            _dispositionList.ButtonsSizeMode = RibbonElementSizeMode.Medium;
            _dispositionList.FlashImage = Tools4Libraries.Resources.ResourceIconSet16Default.mosaique;
            _dispositionList.Image = Tools4Libraries.Resources.ResourceIconSet16Default.mosaique;
            _panelDisposition.Items.Add(_dispositionList);

            _veryBigIcon = new RibbonButton("Très grande icônes");
            _veryBigIcon.MaxSizeMode = RibbonElementSizeMode.Medium;
            _veryBigIcon.MinSizeMode = RibbonElementSizeMode.Medium;
            _veryBigIcon.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.veryBigPicture;
            _dispositionList.Buttons.Add(_veryBigIcon);

            _bigIcon = new RibbonButton("Grandes icônes");
            _bigIcon.MaxSizeMode = RibbonElementSizeMode.Medium;
            _bigIcon.MinSizeMode = RibbonElementSizeMode.Medium;
            _bigIcon.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.bigPicture;
            _dispositionList.Buttons.Add(_bigIcon);

            _mediumIcon = new RibbonButton("Icônes moyennes");
            _mediumIcon.MaxSizeMode = RibbonElementSizeMode.Medium;
            _mediumIcon.MinSizeMode = RibbonElementSizeMode.Medium;
            _mediumIcon.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.bigIcon;
            _dispositionList.Buttons.Add(_mediumIcon);

            _smallIcon = new RibbonButton("Petites icônes");
            _smallIcon.MaxSizeMode = RibbonElementSizeMode.Medium;
            _smallIcon.MinSizeMode = RibbonElementSizeMode.Medium;
            _smallIcon.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.smallIcon;
            _dispositionList.Buttons.Add(_smallIcon);

            _listIcon = new RibbonButton("Liste");
            _listIcon.MaxSizeMode = RibbonElementSizeMode.Medium;
            _listIcon.MinSizeMode = RibbonElementSizeMode.Medium;
            _listIcon.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.list;
            _dispositionList.Buttons.Add(_listIcon);

            _detailIcon = new RibbonButton("Détail");
            _detailIcon.MaxSizeMode = RibbonElementSizeMode.Medium;
            _detailIcon.MinSizeMode = RibbonElementSizeMode.Medium;
            _detailIcon.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.detail;
            _dispositionList.Buttons.Add(_detailIcon);

            _mosaiqueIcon = new RibbonButton("Mosaïque");
            _mosaiqueIcon.MaxSizeMode = RibbonElementSizeMode.Medium;
            _mosaiqueIcon.MinSizeMode = RibbonElementSizeMode.Medium;
            _mosaiqueIcon.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.mosaique;
            _dispositionList.Buttons.Add(_mosaiqueIcon);

            _contentIcon = new RibbonButton("Contenu");
            _contentIcon.MaxSizeMode = RibbonElementSizeMode.Medium;
            _contentIcon.MinSizeMode = RibbonElementSizeMode.Medium;
            _contentIcon.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.content;
            _dispositionList.Buttons.Add(_contentIcon);
            #endregion

            #region Current display
            _panelCurrentDisplay = new RibbonPanel("Affichage actuel");
            _tabDisplay.Panels.Add(_panelCurrentDisplay);

            _sort = new RibbonButton("Trier par");
            _sort.MinSizeMode = RibbonElementSizeMode.Large;
            _sort.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.sort;
            _panelCurrentDisplay.Items.Add(_sort);

            _groupBy = new RibbonButton("Grouper par");
            _groupBy.MaxSizeMode = RibbonElementSizeMode.Medium;
            _groupBy.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.group;
            _panelCurrentDisplay.Items.Add(_groupBy);

            _addColumns = new RibbonButton("Ajouter des colonnes");
            _addColumns.MaxSizeMode = RibbonElementSizeMode.Medium;
            _addColumns.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.addColumn;
            _panelCurrentDisplay.Items.Add(_addColumns);

            _adjustColumnsSize = new RibbonButton("Ajuster la taille de toutes les colonnes");
            _adjustColumnsSize.MaxSizeMode = RibbonElementSizeMode.Medium;
            _adjustColumnsSize.SmallImage = Tools4Libraries.Resources.ResourceIconSet16Default.adjustColumn;
            _panelCurrentDisplay.Items.Add(_adjustColumnsSize);
            #endregion

            #region Disply / Hide
            _panelDisplayHide = new RibbonPanel("Afficher/Masquer");
            _tabDisplay.Panels.Add(_panelDisplayHide);

            _compenentCheckBoxes = new RibbonCheckBox();
            _compenentCheckBoxes.Text = "Case à cocher les éléments";
            _compenentCheckBoxes.Value = "Case à cocher les éléments";
            _compenentCheckBoxes.MaxSizeMode = RibbonElementSizeMode.Overflow;
            _compenentCheckBoxes.MinSizeMode = RibbonElementSizeMode.Overflow;
            _compenentCheckBoxes.TextAlignment = RibbonItem.RibbonItemTextAlignment.Left;
            _compenentCheckBoxes.LabelWidth = 200;
            _panelDisplayHide.Items.Add(_compenentCheckBoxes);

            _fileExtentionDisplay = new RibbonCheckBox();
            _fileExtentionDisplay.Text = "Extensions de noms de fichiers";
            _fileExtentionDisplay.Value = "Extensions de noms de fichiers";
            _fileExtentionDisplay.MaxSizeMode = RibbonElementSizeMode.Overflow;
            _fileExtentionDisplay.MinSizeMode = RibbonElementSizeMode.Overflow;
            _fileExtentionDisplay.LabelWidth = 200;
            _panelDisplayHide.Items.Add(_fileExtentionDisplay);

            _displayHidenComponents = new RibbonCheckBox();
            _displayHidenComponents.Text = "Eléments masqués";
            _displayHidenComponents.Value = "Eléments masqués";
            _displayHidenComponents.MaxSizeMode = RibbonElementSizeMode.Overflow;
            _displayHidenComponents.MinSizeMode = RibbonElementSizeMode.Overflow;
            _displayHidenComponents.LabelWidth = 200;
            _panelDisplayHide.Items.Add(_displayHidenComponents);

            _hideSelectedComponents = new RibbonButton("Masquer les éléments sélectionnés");
            _hideSelectedComponents.MinSizeMode = RibbonElementSizeMode.Large;
            _hideSelectedComponents.LargeImage = Tools4Libraries.Resources.ResourceIconSet32Default.displayHide;
            _panelDisplayHide.Items.Add(_hideSelectedComponents);
            #endregion
        }
        #endregion

        #region Event
        #endregion
    }
}
