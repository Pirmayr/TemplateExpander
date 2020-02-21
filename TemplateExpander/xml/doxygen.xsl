<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:output method="xml" version="1.0" indent="yes" standalone="yes" />
  <xsl:template match="/">
    <documentation>
      <xsl:for-each select="doxygenindex/compound">
        <xsl:for-each select="document(concat(@refid, '.xml'))/doxygen/compounddef">
          <compound name="{./compoundname}" kind="{@kind}">
            <xsl:if test="./sectiondef">
              <xsl:for-each select="./sectiondef">
                <section kind="{@kind}">
                  <xsl:if test="./memberdef">
                    <xsl:for-each select="./memberdef">
                      <member name="{./name}" kind="{@kind}" type="{./type}">
                        <xsl:if test="./briefdescription/child::* != ''">
                          <brief>
                            <xsl:copy-of select="./briefdescription/child::*" />
                          </brief>
                        </xsl:if>
                        <xsl:if test="./param">
                          <parameters>
                            <xsl:for-each select="./param">
                              <parameter name="{./declname}" type="{./type}">
                                <xsl:for-each select="../detaileddescription/para/parameterlist/parameteritem[./parameternamelist/parametername=current()/declname]">
                                  <brief>
                                    <xsl:copy-of select="./parameterdescription/child::*" />
                                  </brief>
                                </xsl:for-each>
                              </parameter>
                            </xsl:for-each>
                          </parameters>
                        </xsl:if>
                        <xsl:if test="./detaileddescription">
                          <xsl:for-each select="./detaileddescription">
                            <xsl:if test="./para">
                              <xsl:for-each select="./para">
                                <xsl:choose>
                                  <xsl:when test="./parameterlist or ./simplesect">
                                    <xsl:if test="./simplesect">
                                      <returns>
                                        <xsl:copy-of select="./simplesect/child::*" />
                                      </returns>
                                    </xsl:if>
                                  </xsl:when>
                                  <xsl:otherwise>
                                    <remarks>
                                      <xsl:copy-of select="." />
                                    </remarks>
                                  </xsl:otherwise>
                                </xsl:choose>
                              </xsl:for-each>
                            </xsl:if>
                          </xsl:for-each>
                        </xsl:if>
                      </member>
                    </xsl:for-each>
                  </xsl:if>
                </section>
              </xsl:for-each>
            </xsl:if>
            <xsl:if test="./detaileddescription">
              <xsl:for-each select="./detaileddescription">
                <description>
                  <xsl:if test="./sect1">
                    <xsl:for-each select="./sect1">
                      <section>
                        <title>
                          <xsl:copy-of select="./title" />
                        </title>
                      </section>
                    </xsl:for-each>
                  </xsl:if>
                </description>
              </xsl:for-each>
            </xsl:if>
          </compound>
        </xsl:for-each>
      </xsl:for-each>
    </documentation>
  </xsl:template>
</xsl:stylesheet>