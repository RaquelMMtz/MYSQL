USE EstudiodeAnimacion;
CREATE TABLE Animatic2D
(
idAnimatic2D INT  NOT NULL,
fechaEntrega DATETIME NOT NULL,
personaje VARCHAR (50) NOT NULL ,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idAnimatic2D)
);

CREATE TABLE ArteConceptual
(
 idArteConceptual INT NOT NULL,
 concepto VARCHAR (50) NOT NULL,
 fechaEntrega DATETIME NOT NULL ,
 estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idArteConceptual)
);
CREATE TABLE Cambio
(
idCambio INT NOT NULL,
cambio VARCHAR (50) NOT NULL,
descripcion VARCHAR (100) NOT NULL,
fecha DATETIME NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idCambio)
);
CREATE TABLE Director
(
idDirector INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idDirector)
);

CREATE TABLE Ingreso
(
idIngreso INT  NOT NULL,
ingreso INT NOT NULL,
descripcion VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idIngreso)
);
CREATE TABLE JuntaDirectiva
(
idJuntaDirectiva INT NOT NULL,
motivo VARCHAR (50) NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idJuntaDirectiva)
);
CREATE TABLE Layout
(
idLayout INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
correccionDibujo VARCHAR (50) NOT NULL,
tipo VARCHAR (30),
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idLayout)
);
CREATE TABLE Musico
(
idMusico INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
tipoMusica VARCHAR (30) NOT NULL, 
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idMusico)
);
CREATE TABLE PostProduccion
(
idPostProduccion INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
correccionFinal VARCHAR (100) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idPostProduccion)
);

CREATE TABLE StoryBoard
(
idStoryBoard INT NOT NULL,
tituloEscena VARCHAR (30) NOT NULL,
ideaEscena VARCHAR (50) NOT NULL,
fechaEntrega DATETIME NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idStoryBoard)
);
CREATE TABLE VFX
(idVFX INT NOT  NULL,
fechaEntrega DATETIME NOT NULL,
tipo VARCHAR (50) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idVFX)
);
CREATE TABLE Actor
(
idActor INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
personaje VARCHAR (30) NOT NULL, 
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idActor)
);
CREATE TABLE AsistenteAnimacion
(
idAsistenteAnimacion INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idAsistenteAnimacion)
);
CREATE TABLE Animacion
(
idAnimacion INT NOT NULL,
nombre VARCHAR (30) NOT NULL,
fechaEntrega DATETIME NOT NULL,
idAsistenteAnimacion INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idAnimacion)
);
CREATE TABLE Animador
(
idAnimador INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
especializacion VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idAnimador)
);
CREATE TABLE Artista
(
idArtista INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
especializacion VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idArtista)
);
CREATE TABLE Colaboracion
(
idColaboracion INT NOT NULL,
estudio VARCHAR (50) NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idColaboracion)
);
CREATE TABLE ColorScript
(
idColorScript INT NOT NULL,
descripcion VARCHAR (50) NOT NULL,
fechaEntrega DATETIME NOT NULL,
idArtista INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idColorScript)
); 
CREATE TABLE Tecnico
(
idTecnico INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
especializacion VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idTecnico)
);
CREATE TABLE Compositing
(
idCompositing INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idCompositing)
);
CREATE TABLE CorreccionColor
(
idCorreccionColor INT NOT NULL,
descripcion VARCHAR (50) NOT NULL,
fechaEntrega DATETIME NOT NULL,
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idCorreccionColor)
);
CREATE TABLE DiaPresentacion
(
idDiaPresentacion INT NOT NULL,
descripcion VARCHAR (50) NOT NULL,
fecha DATETIME NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idDiaPresentacion)
);
CREATE TABLE  Directivo
(
idDirectivo INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
departamento VARCHAR (50) NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idDirectivo)
);
CREATE TABLE Esqueletizacion
(
idEsqueletizacion INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idEsqueletizacion)
);
CREATE TABLE Gerente 
(
idGerente INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
departamento VARCHAR (50) NOT NULL,
idDirectivo INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idGerente)
);
CREATE TABLE ExhibicionInternacional
(
idExhibicionInternacional INT NOT NULL,
feha DATETIME NOT NULL,
calle VARCHAR (50) NOT NULL,
numero CHAR (100) NOT NULL,
colonia VARCHAR (50) NOT NULL,
ciudad VARCHAR (50) NOT NULL,
pais VARCHAR (50) NOT NULL,
idGerente INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idExhibicionInternacional)
); 
CREATE TABLE ExhibicionNacional
(
idExhibicionNacional INT NOT NULL,
feha DATETIME NOT NULL,
calle VARCHAR (50) NOT NULL,
numero CHAR (100) NOT NULL,
colonia VARCHAR (50) NOT NULL,
ciudad VARCHAR (50) NOT NULL,
codigoPostal CHAR (6) NOT NULL,
idGerente INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idExhibicionNacional)
); 
CREATE TABLE Fondista
(
idFondista INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idFondista)
); 
CREATE TABLE FxPersonaje
(
idFxPersonaje INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idFxPersonaje)
);
CREATE TABLE GrabacionVoz
(
idGrabacionVoz INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idGrabacionVoz)
);
CREATE TABLE Guionista
(
idGuionista INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
idGerente INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idGuionista)
);
CREATE TABLE Guion
(
idGuion INT NOT NULL,
titulo VARCHAR (30) NOT NULL,
fechaEntrega DATETIME NOT NULL,
idGuionista INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idGuion)
);
CREATE TABLE Idea
(
idIdea INT NOT NULL,
propuesta VARCHAR (100) NOT NULL,
fechaEntrega DATETIME NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idIdea)
);
CREATE TABLE Iluminacion
(
idIluminacion INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
descripcion VARCHAR (50),
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idIluminacion)
);
CREATE TABLE Masterizacion
(
idMasterizacion INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
tipoAudio VARCHAR (30),
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idMasterizacion)
);
CREATE TABLE MattePainting
(
idMattePainting INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
idFondista INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idMattePainting)
);
CREATE TABLE Modelado
(
idModelado INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
idAsistenteAnimacion INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idModelado)
);
CREATE TABLE Musica
(
idMusica INT NOT NULL,
nombre VARCHAR (30)NOT NULL,
genero VARCHAR (30)NOT NULL,
fechaEntrega DATETIME NOT NULL,
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idMusica)
);
CREATE TABLE Patrocinador
(
idPatrocinador INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
empresa VARCHAR (30) NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idPatrocinador)
);
CREATE TABLE Pelicula
(
idPelicula INT NOT NULL,
titulo VARCHAR (30) NOT NULL,
genero VARCHAR (30) NOT NULL,
clasificacion VARCHAR (6) NOT NULL,
duracion CHAR (150) NOT NULL,
idJuntaDirectiva INT NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idPelicula)
);
CREATE TABLE PreExhibicion
(
idPreExhibicion INT NOT NULL,
feha DATETIME NOT NULL,
calle VARCHAR (50) NOT NULL,
numero CHAR (100) NOT NULL,
colonia VARCHAR (50) NOT NULL,
ciudad VARCHAR (50) NOT NULL,
codigoPostal CHAR (6) NOT NULL,
numParticipantes CHAR (100) NOT NULL,
idGerente INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idPreExhibicion)
);
CREATE TABLE Presupuesto
(
idPresupuesto INT NOT NULL,
desarrolloInv INT NOT NULL,
areaTecnica INT NOT NULL, 
areaArtistica INT NOT NULL,
marketing INT NOT NULL,
idGerente INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idPresupuesto)
);
CREATE TABLE Productor
(
idProductor INT NOT NULL,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
idGerente INT NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idProductor)
);
CREATE TABLE Publicidad
(
idPublicidad INT NOT NULL,
medioTransimicion VARCHAR (30),
precio INT NOT NULL,
idGerente INT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idPublicidad)
);
CREATE TABLE PulidoCamara
(
idPulidoCamara INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
detalles VARCHAR (100),
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idPulidoCamara)
);
CREATE TABLE Rediseño
(
idRediseño INT NOT NULL,
primerRediseño DATETIME NOT NULL,
segundoRediseño DATETIME NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idRediseño)
);
CREATE TABLE Revision
(
idRevision INT NOT NULL,
primeraRevision DATETIME NOT NULL,
segundaRevision DATETIME NOT NULL,
idDirector INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY key (idRevision)
);
CREATE TABLE SetDressing
(
idSetDressing INT NOT NULL,
fechaEntrega DATETIME NOT NULL,
idFondista INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idSetDressing)
);
CREATE TABLE SFX
(
idSFX INT NOT NULL,
tipo VARCHAR (50) NOT NULL,
fechaEntrega DATETIME NOT NULL,
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idSFX)
);
CREATE TABLE Texturizado
(
idTexturizado INT NOT NULL,
tipo  VARCHAR (50) NOT NULL,
fechaEntrega DATETIME NOT NULL,
idTecnico INT NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idTexturizado)
);
CREATE TABLE ActorGrabacionVoz
(
idActorGrabacionVoz INT NOT NULL,
idActor INT NOT NULL,
idGrabacionVoz INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idActorGrabacionVoz)
);
CREATE TABLE AnimacionAnimador
(
idAnimacionAnimador INT NOT NULL,
idAnimacion INT NOT NULL,
idAnimador INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idAnimacionAnimador)
);
CREATE TABLE AnimadorAnimatic2D
(
idAnimadorAnimatic2D INT NOT NULL,
idAnimador INT NOT NULL,
idAnimatic2D INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idAnimadorAnimatic2D)
);
CREATE TABLE AnimadorModelo
(
idAnimadorModelo INT NOT NULL,
idAnimador INT NOT NULL,
idModelado INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idAnimadorModelo)
);
CREATE TABLE ArtistaAreaConceptual
(
idArtistaAreaConceptual INT NOT NULL,
idArtista INT NOT NULL,
idArteConceptual INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idArtistaAreaConceptual)
);
CREATE TABLE ArtistaStoryBoard
(
idArtistaStoryBoard INT NOT NULL,
idArtista INT NOT NULL,
idStoryBoard INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idArtistaStoryBoard)
);
CREATE TABLE CambioDirectivo
(
idCambioDirectivo INT NOT NULL,
idCambio INT NOT NULL,
idDirectivo INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idCambioDirectivo)
);
CREATE TABLE DirectorGerente
(
idDirectorGerente INT NOT NULL,
idDirector INT NOT NULL,
idGerente INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idDirectorGerente)
);
CREATE TABLE IngresoExhibicionInternacional
(
idIngresoExhibicionInternacional INT NOT NULL,
idIngreso INT NOT NULL,
idExhibicionInternacional INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idIngresoExhibicionInternacional)
);
CREATE TABLE IngresoExhibicionNacional
(
idIngresoExhibicionNacional INT NOT NULL,
idIngreso INT NOT NULL,
idExhibicionNacional INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idIngresoExhibicionNacional)
);
CREATE TABLE  LayoutTecnico
(
idLayoutTecnico INT NOT NULL,
idLayout INT NOT NULL,
idTecnico INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idLayoutTecnico)
);
CREATE TABLE MusicaMusico
(
idMusicaMusico INT NOT NULL,
idMusica INT NOT NULL,
idMusico INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idMusicaMusico)
);
CREATE TABLE PostProduccionTecnico
(
idPostProduccionTecnico INT NOT NULL,
idPostProduccion INT NOT NULL,
idTecnico INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idPostProduccionTecnico)
);
CREATE TABLE VFXTecnico
(
idVFXTecnico INT NOT NULL,
idVFX INT NOT NULL,
idTecnico INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BIT DEFAULT 1 NOT NULL,
PRIMARY KEY (idVFXTecnico)
);

#LLAVES FOREANEAS
#ACTOR
ALTER TABLE Actor ADD CONSTRAINT FK_ActorDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#ASISTENTEANIMACION
ALTER TABLE AsistenteAnimacion ADD CONSTRAINT FK_AsistenteAnimacionDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#ANIMACION
ALTER TABLE Animacion ADD CONSTRAINT FK_AnimacionAsistenteAnimacion FOREIGN KEY(idAsistenteAnimacion) REFERENCES AsistenteAnimacion(idAsistenteAnimacion);
#ANIMADOR
ALTER TABLE Animador ADD CONSTRAINT FK_AnimadorDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#ARTISTA
ALTER TABLE Artista ADD CONSTRAINT FK_ArtistaDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#Colaboracion
ALTER TABLE Colaboracion ADD CONSTRAINT FK_ColaboracionJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
#ColorScript
ALTER TABLE ColorScript ADD CONSTRAINT FK_ColorScriptArtista FOREIGN KEY(idArtista) REFERENCES Artista(idArtista);
#Tecnico
ALTER TABLE Tecnico ADD CONSTRAINT FK_TecnicoDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#Compositing
ALTER TABLE Compositing ADD CONSTRAINT FK_CompositingTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#CorreccionColor
ALTER TABLE CorreccionColor ADD CONSTRAINT FK_CorreccionColorTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#DiaPresentacion
ALTER TABLE DiaPresentacion ADD CONSTRAINT FK_DiaPresentacionJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
#Directivo
ALTER TABLE Directivo ADD CONSTRAINT FK_DirectivoJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
#Esqueletizacion
ALTER TABLE Esqueletizacion ADD CONSTRAINT FK_EsqueletizacionTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#Gerente
ALTER TABLE Gerente ADD CONSTRAINT FK_GerenteDirectivo FOREIGN KEY(idDirectivo) REFERENCES Directivo(idDirectivo);
#ExhibicionInternacional
ALTER TABLE ExhibicionInternacional ADD CONSTRAINT FK_ExhibicionInternacionalGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
#ExhibicionNacional
ALTER TABLE ExhibicionNacional ADD CONSTRAINT FK_ExhibicionNacionalGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
#Fondista
ALTER TABLE Fondista ADD CONSTRAINT FK_FondistaDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#FxPersonaje
ALTER TABLE FxPersonaje ADD CONSTRAINT FK_FxPersonajeTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#GrabacionVoz
ALTER TABLE GrabacionVoz ADD CONSTRAINT FK_GrabacionVozTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#Guionista
ALTER TABLE Guionista ADD CONSTRAINT FK_GuionistaGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
#Guion
ALTER TABLE Guion ADD CONSTRAINT FK_GuionGuionista FOREIGN KEY(idGuionista) REFERENCES Guionista(idGuionista);
#Idea
ALTER TABLE Idea ADD CONSTRAINT FK_IdeaJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
#Iluminacion
ALTER TABLE Iluminacion ADD CONSTRAINT FK_IluminacionTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#Masterizacion
ALTER TABLE Masterizacion ADD CONSTRAINT FK_MasterizacionTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#MattePainting
ALTER TABLE MattePainting ADD CONSTRAINT FK_MattePaintingFondista FOREIGN KEY(idFondista) REFERENCES Fondista(idFondista);
#Modelado
ALTER TABLE Modelado ADD CONSTRAINT FK_ModeladoAsistenteAnimacion FOREIGN KEY(idAsistenteAnimacion) REFERENCES AsistenteAnimacion(idAsistenteAnimacion);
#Musica
ALTER TABLE Musica ADD CONSTRAINT FK_MusicaTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#Patrocinador
ALTER TABLE Patrocinador ADD CONSTRAINT FK_PatrocinadorJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
#Pelicula
ALTER TABLE Pelicula ADD CONSTRAINT FK_PeliculaJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
ALTER TABLE Pelicula ADD CONSTRAINT FK_PeliculaDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#PreExhibicion
ALTER TABLE PreExhibicion ADD CONSTRAINT FK_PreExhibicionGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
#Presupuesto
ALTER TABLE Presupuesto ADD CONSTRAINT FK_PresupuestoGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
#Productor
ALTER TABLE Productor ADD CONSTRAINT FK_ProductorGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
ALTER TABLE Productor ADD CONSTRAINT FK_ProductorDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#Pubilicidad
ALTER TABLE Publicidad ADD CONSTRAINT FK_PubilicidadGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
#PulidoCamara
ALTER TABLE PulidoCamara ADD CONSTRAINT FK_PulidoCamaraTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#Rediseño
ALTER TABLE Rediseño ADD CONSTRAINT FK_RediseñoDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#Revision
ALTER TABLE Revision ADD CONSTRAINT FK_RevisionDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
#SetDressing
ALTER TABLE SetDressing ADD CONSTRAINT FK_SetDressingFondista FOREIGN KEY(idFondista) REFERENCES Fondista(idFondista);
#SFX
ALTER TABLE SFX ADD CONSTRAINT FK_SFXTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#Texturizado
ALTER TABLE Texturizado ADD CONSTRAINT FK_TexturizadoTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#ActorGrabacionVoz
ALTER TABLE ActorGrabacionVoz ADD CONSTRAINT FK_ActorGrabacionVozActor FOREIGN KEY(idActor) REFERENCES Actor(idActor);
ALTER TABLE ActorGrabacionVoz ADD CONSTRAINT FK_ActorGrabacionVozGrabacionVoz FOREIGN KEY(idGrabacionVoz) REFERENCES GrabacionVoz(idGrabacionVoz);
#AnimacionANimador
ALTER TABLE AnimacionAnimador ADD CONSTRAINT FK_AnimacionAnimadorAnimacion FOREIGN KEY(idAnimacion) REFERENCES Animacion(idAnimacion);
ALTER TABLE AnimacionAnimador ADD CONSTRAINT FK_AnimacionAnimadorAnimador FOREIGN KEY(idAnimador) REFERENCES Animador(idAnimador);
#AnimadorAnimatic 2D
ALTER TABLE AnimadorAnimatic2D ADD CONSTRAINT FK_AnimadorAnimatic2DAnimador FOREIGN KEY(idAnimador) REFERENCES Animador(idAnimador);
ALTER TABLE AnimadorAnimatic2D ADD CONSTRAINT FK_AnimadorAnimatic2DAnimatic2D FOREIGN KEY(idAnimatic2D) REFERENCES Animatic2D(idAnimatic2D);
#AnimadorModelo
ALTER TABLE AnimadorModelo ADD CONSTRAINT FK_AnimadorModeloAnimador FOREIGN KEY(idAnimador) REFERENCES Animador(idAnimador);
ALTER TABLE AnimadorModelo ADD CONSTRAINT FK_AnimadorModeloModelado FOREIGN KEY(idModelado) REFERENCES Modelado(idModelado);
#ArtistaAreaConceptual
ALTER TABLE ArtistaAreaConceptual ADD CONSTRAINT FK_ArtistaAreaConceptualArtista FOREIGN KEY(idArtista) REFERENCES Artista(idArtista);
ALTER TABLE ArtistaAreaConceptual ADD CONSTRAINT FK_ArtistaAreaConceptualArteConceptual FOREIGN KEY(idArteConceptual) REFERENCES ArteConceptual(idArteConceptual);
#ArtistaStoryBoard
ALTER TABLE ArtistaStoryBoard ADD CONSTRAINT FK_ArtistaStoryBoardArtista FOREIGN KEY(idArtista) REFERENCES Artista(idArtista);
ALTER TABLE ArtistaStoryBoard ADD CONSTRAINT FK_ArtistaStoryBoardStoryBoard FOREIGN KEY(idStoryBoard) REFERENCES StoryBoard(idStoryBoard);
#CambioDirectivo
ALTER TABLE CambioDirectivo ADD CONSTRAINT FK_CambioDirectivoCambio FOREIGN KEY(idCambio) REFERENCES Cambio(idCambio);
ALTER TABLE CambioDirectivo ADD CONSTRAINT FK_CambioDirectivoDirectivo FOREIGN KEY(idDirectivo) REFERENCES Directivo(idDirectivo);
#DirectorGerente
ALTER TABLE DirectorGerente ADD CONSTRAINT FK_DirectorGerenteDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
ALTER TABLE DirectorGerente ADD CONSTRAINT FK_DirectorGerenteGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
#IngresoExhibicionInternacional
ALTER TABLE IngresoExhibicionInternacional ADD CONSTRAINT FK_IngresoExhibicionInternacionalIngreso FOREIGN KEY(idIngreso) REFERENCES Ingreso(idIngreso);
ALTER TABLE IngresoExhibicionInternacional ADD CONSTRAINT FK_IngresoExhibicionInternacionalExhibicionInternacional FOREIGN KEY(idExhibicionInternacional) REFERENCES ExhibicionInternacional(idExhibicionInternacional);
#IngresoExhibicionNacional
ALTER TABLE IngresoExhibicionNacional ADD CONSTRAINT FK_IngresoExhibicionNacionalIngreso FOREIGN KEY(idIngreso) REFERENCES Ingreso(idIngreso);
ALTER TABLE IngresoExhibicionNacional ADD CONSTRAINT FK_IngresoExhibicionNacionalExhibicionNacional FOREIGN KEY(idExhibicionNacional) REFERENCES ExhibicionNacional(idExhibicionNacional);
#LayoutTecnico
ALTER TABLE LayoutTecnico ADD CONSTRAINT FK_LayoutTecnicoLayout FOREIGN KEY(idLayout) REFERENCES Layout(idLayout);
ALTER TABLE LayoutTecnico ADD CONSTRAINT FK_LayoutTecnicoTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#MusicaMusico
ALTER TABLE MusicaMusico ADD CONSTRAINT FK_MusicaMusicoMusica FOREIGN KEY(idMusica) REFERENCES Musica(idMusica);
ALTER TABLE MusicaMusico ADD CONSTRAINT FK_MusicaMusicoMusico FOREIGN KEY(idMusico) REFERENCES Musico(idMusico);
#PostProduccionTecnico
ALTER TABLE PostProduccionTecnico ADD CONSTRAINT FK_PostProduccionTecnicoPostProduccion FOREIGN KEY(idPostProduccion) REFERENCES PostProduccion(idPostProduccion);
ALTER TABLE PostProduccionTecnico ADD CONSTRAINT FK_PostProduccionTecnicoTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
#VFXTecnico
ALTER TABLE VFXTecnico ADD CONSTRAINT FK_VFXTecnicoTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
ALTER TABLE VFXTecnico ADD CONSTRAINT FK_VFXTecnicoVFX FOREIGN KEY(idVFX) REFERENCES VFX(idVFX);

#INDICES
CREATE INDEX IX_Animatic2D ON Animatic2D(idAnimatic2D);
CREATE INDEX IX_ArteConceptual ON ArteConceptual(idArteConceptual);
CREATE INDEX IX_Cambio ON Cambio(idCambio);
CREATE INDEX IX_Director ON Director(idDirector);
CREATE INDEX IX_Ingreso ON Ingreso(idIngreso);
CREATE INDEX IX_JuntaDirectiva ON JuntaDirectiva(idJuntaDirectiva);
CREATE INDEX IX_Layout ON Layout(idLayout);
CREATE INDEX IX_Musico ON Musico(idMusico);
CREATE INDEX IX_PostProduccion ON PostProduccion(idPostProduccion);
CREATE INDEX IX_StoryBoard ON StoryBoard(idStoryBoard);
CREATE INDEX IX_VFX ON VFX(idVFX);
CREATE INDEX IX_Actor ON Actor(idActor);
CREATE INDEX IX_AsistenteAnimacion ON AsistenteAnimacion(idAsistenteAnimacion);
CREATE INDEX IX_Animacion ON Animacion (idAnimacion);
CREATE INDEX IX_Animador ON Animador(idAnimador);
CREATE INDEX IX_Artista ON Artista(idArtista);
CREATE INDEX IX_Colaboracion ON Colaboracion(idColaboracion);
CREATE INDEX IX_ColorScript ON ColorScript(idColorScript);
CREATE INDEX IX_Tecnico ON Tecnico(idTecnico);
CREATE INDEX IX_Compositing ON Compositing(idCompositing);
CREATE INDEX IX_CorreccionColor ON CorreccionColor(idCorreccionColor);
CREATE INDEX IX_DiaPresentacion ON DiaPresentacion(idDiaPresentacion);
CREATE INDEX IX_Directivo ON Directivo(idDirectivo);
CREATE INDEX IX_Esqueletizacion ON Esqueletizacion(idEsqueletizacion);
CREATE INDEX IX_Gerente ON Gerente(idGerente);
CREATE INDEX IX_ExhibicionInternacional ON ExhibicionInternacional(idExhibicionInternacional);
CREATE INDEX IX_ExhibicionNacional ON ExhibicionNacional(idExhibicionNacional);
CREATE INDEX IX_Fondista ON Fondista(idFondista);
CREATE INDEX IX_FxPersonaje ON FxPersonaje(idFxPersonaje);
CREATE INDEX IX_GrabacionVoz ON GrabacionVoz(idGrabacionVoz);
CREATE INDEX IX_Guionista ON Guionista(idGuionista);
CREATE INDEX IX_Guion ON Guion(idGuion);
CREATE INDEX IX_Idea ON Idea(idIdea);
CREATE INDEX IX_Iluminacion ON Iluminacion(idIluminacion);
CREATE INDEX IX_Masterizacion ON Masterizacion(idMasterizacion);
CREATE INDEX IX_MattePainting ON MattePainting(idMattePainting);
CREATE INDEX IX_Modelado ON Modelado(idModelado);
CREATE INDEX IX_Musica ON Musica(idMusica);
CREATE INDEX IX_Patrocinador ON Patrocinador(idPatrocinador);
CREATE INDEX IX_Pelicula ON Pelicula(idPelicula);
CREATE INDEX IX_PreExhibicion ON PreExhibicion(idPreExhibicion);
CREATE INDEX IX_Presupuesto ON Presupuesto(idPresupuesto);
CREATE INDEX IX_Productor ON Productor(idProductor);
CREATE INDEX IX_Publicidad ON Publicidad(idPublicidad);
CREATE INDEX IX_PulidoCamara ON PulidoCamara(idPulidoCamara);
CREATE INDEX IX_Rediseño ON Rediseño(idRediseño);
CREATE INDEX IX_Revision ON Revision(idRevision);
CREATE INDEX IX_SetDressing ON SetDressing(idSetDressing);
CREATE INDEX IX_SFX ON SFX(idSFX);
CREATE INDEX IX_Texturizado ON Texturizado(idTexturizado);
CREATE INDEX IX_ActorGrabacionVoz ON ActorGrabacionVoz(idActorGrabacionVoz);
CREATE INDEX IX_AnimacionAnimador ON AnimacionAnimador(idAnimacionAnimador);
CREATE INDEX IX_AnimadorAnimatic2D ON AnimadorAnimatic2D(idAnimadorAnimatic2D);
CREATE INDEX IX_AnimadorModelo ON AnimadorModelo(idAnimadorModelo);
CREATE INDEX IX_ArtistaArteConceptual ON ArtistaAreaConceptual(idArtistaAreaConceptual);
CREATE INDEX IX_ArtistaStoryBoard ON ArtistaStoryBoard(idArtistaStoryBoard);
CREATE INDEX IX_CambioDirectivo ON CambioDirectivo(idCambioDirectivo);
CREATE INDEX IX_DirectorGerente ON DirectorGerente(idDirectorGerente);
CREATE INDEX IX_IngresoExhibicionInternacional ON IngresoExhibicionInternacional(idIngresoExhibicionInternacional);
CREATE INDEX IX_IngrecioExhibicionNacional ON IngresoExhibicionNacional(idIngresoExhibicionNacional);
CREATE INDEX IX_LayoutTecnico ON LayoutTecnico(idLayoutTecnico);
CREATE INDEX IX_MusicaMusico ON MusicaMusico(idMusicaMusico);
CREATE INDEX IX_PostProduccionTecnico ON PostProduccionTecnico(idPostProduccionTecnico);
CREATE INDEX IX_VFXTecnico ON VFXTecnico(idVFXTecnico);



